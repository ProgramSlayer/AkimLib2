﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp1.ViewModels;

public class BaseViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    public virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null) => PropertyChanged?.Invoke(this, new(propertyName));
}
