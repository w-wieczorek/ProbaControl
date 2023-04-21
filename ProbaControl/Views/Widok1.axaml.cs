using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ProbaControl.ViewModels;

namespace ProbaControl.Views;

public partial class Widok1 : UserControl
{
    public Widok1()
    {
        InitializeComponent();
        DataContext = new Widok1ViewModel();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}