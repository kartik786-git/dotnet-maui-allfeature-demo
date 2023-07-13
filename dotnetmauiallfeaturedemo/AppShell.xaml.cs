using dotnetmauiallfeaturedemo.Views;

namespace dotnetmauiallfeaturedemo;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(BlogDetailsPage), typeof(BlogDetailsPage));
		Routing.RegisterRoute(nameof(AddBlogPage), typeof(AddBlogPage));
	}
}
