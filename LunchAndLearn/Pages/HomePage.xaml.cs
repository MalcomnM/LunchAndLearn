using LunchAndLearn.ViewModels;

namespace LunchAndLearn.Pages;

public partial class HomePage : ContentPage
{
    public HomePage(HomePageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

}
