using Avalonia.Rendering;
using CommunityToolkit.Mvvm.ComponentModel;

public partial class MainViewModel : ViewModelBase
{
  [ObservableProperty]
  private string _test = "test";
}