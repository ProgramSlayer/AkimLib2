using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp1.Commands;
using WpfApp1.Context;
using WpfApp1.Helpers;

namespace WpfApp1.ViewModels;

public class MainViewModel : BaseViewModel
{
    private readonly AkimLib2DbContext _context = new(
        new DbContextOptionsBuilder<AkimLib2DbContext>()
        //.UseSqlite(@"data source=C:\Users\pisar\Пентакон задание\Библиотека элементов\Apps\AkimLib2\WpfApp1\akim_lib_2.db")
        .UseSqlite(@"data source=..\..\..\akim_lib_2.db")
        .Options);

    private OneParamCommand? _addIntruderCommand;
    private OneParamCommand? _editIntruderCommand;
    private OneParamCommand? _deleteIntruderCommand;
    private OneParamCommand? _loadIntrudersCommand;

    private readonly ObservableCollection<IntruderViewModel> _intrudersViewModels = new();
    public IEnumerable<IntruderViewModel> IntrudersViewModels => _intrudersViewModels;

    public ICommand AddIntruderCommand => _addIntruderCommand ??= new OneParamCommand(AddIntruder);
    public ICommand EditIntruderCommand => _editIntruderCommand ??= new OneParamCommand(EditIntruder);
    public ICommand DeleteIntruderCommand => _deleteIntruderCommand ??= new OneParamCommand(DeleteIntruder);
    public ICommand LoadIntrudersCommand => _loadIntrudersCommand ??= new OneParamCommand(LoadIntruders);

    public MainViewModel()
    {
        if (!_context.Intruders.Any())
        {
            Task.Run(() => DataSeeder.Seed(_context)).Wait();
        }
        Task.Run(() => LoadIntruders(null)).Wait();
    }


    private async void AddIntruder(object? commandParameter)
    {
        AddEditIntruderWindow window = new();
        if (window.ShowDialog() != true)
        {
            return;
        }

        if (window.DataContext is not IntruderViewModel intruderVm)
        {
            return;
        }

        var addModel = ViewModelToModelMapper.Map(intruderVm);

        _context.Intruders.Add(addModel);
        await _context.SaveChangesAsync();
        intruderVm = new(addModel);
        _intrudersViewModels.Add(intruderVm);
    }


    private async void EditIntruder(object? commandParameter)
    {
        if (commandParameter is not IntruderViewModel editViewModel)
        {
            return;
        }

        var editModel = await _context.Intruders.SingleOrDefaultAsync(i => i.Id == editViewModel.Id);

        if (editModel == null)
        {
            return;
        }

        AddEditIntruderWindow window = new() { DataContext = new IntruderViewModel(editModel) };

        if (window.ShowDialog() != true)
        {
            return;
        }

        _context.Intruders.Update(editModel);
        await _context.SaveChangesAsync();

        var indexOfEditViewModel = _intrudersViewModels.IndexOf(editViewModel);
        if (indexOfEditViewModel == -1)
        {
            return;
        }

        _intrudersViewModels.RemoveAt(indexOfEditViewModel);
        _intrudersViewModels.Insert(indexOfEditViewModel, new IntruderViewModel(editModel));
    }


    private async void DeleteIntruder(object? commandParameter)
    {
        if (commandParameter is not IntruderViewModel deleteVm)
        {
            return;
        }

        var deleteModel = await _context.Intruders.SingleOrDefaultAsync(i => i.Id == deleteVm.Id);
        if (deleteModel == null)
        {
            return;
        }

        _context.Intruders.Remove(deleteModel);
        await _context.SaveChangesAsync();

        _intrudersViewModels.Remove(deleteVm);
    }


    private async void LoadIntruders(object? commandParameter)
    {
        var intruders = await _context.Intruders.ToListAsync();
        _intrudersViewModels.Clear();
        foreach (var intruder in intruders)
        {
            _intrudersViewModels.Add(new IntruderViewModel(intruder));
        }
    }

}
