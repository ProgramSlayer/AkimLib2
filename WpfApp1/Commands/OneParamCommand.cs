using System;

namespace WpfApp1.Commands;

public class OneParamCommand : BaseCommand
{
    private readonly Action<object?> _execute;
    private readonly Predicate<object?>? _canExecute;

    public OneParamCommand(Action<object?> execute, Predicate<object?>? canExecute = null)
    {
        _execute = execute;
        _canExecute = canExecute;
    }

    public override bool CanExecute(object? parameter)
    {
        return _canExecute == null || _canExecute(parameter);
    }

    public override void Execute(object? parameter)
    {
        _execute(parameter);
    }
}