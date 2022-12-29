using System.Windows;

namespace WpfApp1;

public partial class AddEditIntruderWindow : Window
{
    public AddEditIntruderWindow()
    {
        InitializeComponent();
    }

    private void BtnSaveIntruder_Click(object sender, RoutedEventArgs e)
    {
        DialogResult = true;
        Close();
    }
}
