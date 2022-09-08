using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Models.Characters;
using Services.API;
using System.Collections.ObjectModel;

namespace LunchAndLearn.ViewModels;

public partial class HomePageViewModel: ObservableObject
{
    [ObservableProperty]
    private string firstName;

    [ObservableProperty]
    private string lastName;

    [ObservableProperty]
    private int count;

    [ObservableProperty]
    private ObservableCollection<Character> characters = new ObservableCollection<Character>();

    private ICharacterApi _characterApi;


    public HomePageViewModel(ICharacterApi characterApi)
    {
        _characterApi = characterApi;
    }

    [RelayCommand]
    private void SayHello()
    {
        Console.WriteLine("HELLO WORLD");
    }

    [RelayCommand]
    private void Add()
    {
        Count++;
    }

    [RelayCommand]
    private async Task LoadCharactersAsync()
    {
        GetCharactersResult result = await _characterApi.Characters(1);
        
        if(result.Results.Count != 0)
        {
            foreach (Character character in result.Results)
            {
                Characters.Add(character);
            }
        }
    }
}
