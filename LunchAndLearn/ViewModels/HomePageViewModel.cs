using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Models.Characters;
using Services.API;
using System.Collections.ObjectModel;

namespace LunchAndLearn.ViewModels;

public partial class HomePageViewModel: ObservableObject
{
    [ObservableProperty]
    private string entryTest;


    public HomePageViewModel()
    {
  
    }

    [RelayCommand]
    private void TestAsync()
    {
        Console.WriteLine("Hello World");
    }
}
