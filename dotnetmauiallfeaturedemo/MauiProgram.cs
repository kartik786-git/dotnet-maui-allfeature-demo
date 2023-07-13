using dotnetmauiallfeaturedemo.Services;
using dotnetmauiallfeaturedemo.ViewModels;
using dotnetmauiallfeaturedemo.Views;
using Microsoft.Extensions.Logging;

namespace dotnetmauiallfeaturedemo;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif
		// resolve httpclient
		builder.Services.AddSingleton<HttpClient>();

		//services
		builder.Services.AddSingleton<IBlogService, BlogService>();

		//view model
		builder.Services.AddSingleton<MainViewModel>();
		builder.Services.AddSingleton<BlogDetailViewModel>();
		builder.Services.AddSingleton<AddBlogViewModel>();

		//pages
		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<BlogDetailsPage>();
		builder.Services.AddSingleton<AddBlogPage>();

		return builder.Build();
	}
}
