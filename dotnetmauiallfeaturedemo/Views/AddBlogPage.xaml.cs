using dotnetmauiallfeaturedemo.ViewModels;

namespace dotnetmauiallfeaturedemo.Views;

public partial class AddBlogPage : ContentPage
{
    private readonly AddBlogViewModel _addBlogViewModel;

    public AddBlogPage(AddBlogViewModel addBlogViewModel)
	{
		InitializeComponent();
       BindingContext =  _addBlogViewModel = addBlogViewModel;
    }
}