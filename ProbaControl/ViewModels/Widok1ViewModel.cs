using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ProbaControl.ViewModels;

public partial class Widok1ViewModel : ObservableObject
{
    [RelayCommand]
    public void OnClick1()
    {
        MyReferences.MainWindowOb.ChangeContent(MyReferences.W2Ob);
    }
}