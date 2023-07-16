using dotnetmauiallfeaturedemo.ViewModels;

namespace dotnetmauiallfeaturedemo;

public partial class MainPage : ContentPage
{
    public MainViewModel MainViewModel { get; }
    public MainPage(MainViewModel mainViewModel)
	{
		InitializeComponent();
        BindingContext = MainViewModel = mainViewModel;
    }

    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        await MainViewModel.LoadDataAsync();
    }
    //protected override async void OnAppearing()
    //{
    //    base.OnAppearing();
    //    await MainViewModel.LoadDataAsync();
    //}


}

