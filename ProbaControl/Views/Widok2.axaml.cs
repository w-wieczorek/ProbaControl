using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ProbaControl.ViewModels;

namespace ProbaControl.Views;

public partial class Widok2 : UserControl
{
    public Widok2()
    {
        InitializeComponent();
        DataContext = new Widok2ViewModel();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}