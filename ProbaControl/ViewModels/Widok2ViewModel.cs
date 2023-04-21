using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ProbaControl.ViewModels;

public partial class Widok2ViewModel : ObservableObject
{
    [RelayCommand]
    public void OnClick2()
    {
        MyReferences.MainWindowOb.ChangeContent(MyReferences.W1Ob);
    }
}