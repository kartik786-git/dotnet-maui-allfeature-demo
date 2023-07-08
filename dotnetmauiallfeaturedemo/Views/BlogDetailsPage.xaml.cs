using dotnetmauiallfeaturedemo.ViewModels;

namespace dotnetmauiallfeaturedemo.Views;

public partial class BlogDetailsPage : ContentPage
{
    private BlogDetailViewModel BlogDetailViewModel;
    public BlogDetailsPage(BlogDetailViewModel blogDetailViewModel)
	{
		InitializeComponent();
        BindingContext = BlogDetailViewModel = blogDetailViewModel;
    }

    //protected override void OnNavigatedTo(NavigatedToEventArgs args)
    //{
    //    base.OnNavigatedTo(args);
    //    BlogDetailViewModel.LoadBlogDataByIdAsync();

    //}

}