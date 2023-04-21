using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ProbaControl.Views;

namespace ProbaControl.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{
    private UserControl w1;
    
    [ObservableProperty]
    private string _greeting = "Welcome to Avalonia!";

    public MainWindowViewModel()
    {
        MyReferences.MWVMOb = this;
        MyReferences.W1Ob = new Widok1();
        MyReferences.W2Ob = new Widok2();
        MyReferences.MainWindowOb.ChangeContent(MyReferences.W1Ob);
    }
    
}