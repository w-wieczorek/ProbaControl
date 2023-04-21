using Avalonia.Controls;
using ProbaControl.ViewModels;

namespace ProbaControl.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        MyReferences.MainWindowOb = this;
    }
    
    public void ChangeContent(Control newContent)
    {
        Content = newContent;
    }
}