using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using dotnetmauiallfeaturedemo.Model;
using dotnetmauiallfeaturedemo.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetmauiallfeaturedemo.ViewModels
{
    public partial class AddBlogViewModel : BaseViewModel
    {
        public AddBlogViewModel(IBlogService blogService , IConfiguration configuration)
        {
            _blogService = blogService;
            _configuration = configuration;
            Blog = new Blog();
        }

        [ObservableProperty]
        string failError;

        [ObservableProperty]
        Blog blog;

        private readonly IBlogService _blogService;
        private readonly IConfiguration _configuration;

        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }

        [RelayCommand]
        async Task Save()
        {
            var settings = _configuration.GetRequiredSection("ApiSettings").Get<ApiConfigurationSetting>();
            string apiUrl = $"{settings.ApiUri}api/blog";
            bool isCreated = await _blogService.PostBlogAync(apiUrl, Blog);
            if (isCreated)
            {
                await Shell.Current.GoToAsync("..");
            }
            else
            {
                FailError = "failed to saved";
            }

        }


    }
}
