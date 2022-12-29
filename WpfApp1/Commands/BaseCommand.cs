using System;
using System.Windows.Input;

namespace WpfApp1.Commands;

public abstract class BaseCommand : ICommand
{
    public event EventHandler? CanExecuteChanged;

    public virtual bool CanExecute(object? parameter)
    {
        return true;
    }

    public virtual void Execute(object? parameter)
    {
    }
}
