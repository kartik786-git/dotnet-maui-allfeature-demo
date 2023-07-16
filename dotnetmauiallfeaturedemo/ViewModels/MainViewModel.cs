using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using dotnetmauiallfeaturedemo.Model;
using dotnetmauiallfeaturedemo.Services;
using dotnetmauiallfeaturedemo.Views;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetmauiallfeaturedemo.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        private readonly IBlogService _blogService;
        private readonly IConfiguration _configuration;

        public MainViewModel(IBlogService blogService , IConfiguration configuration)
        {
            _blogService = blogService;
            _configuration = configuration;
        }

        [ObservableProperty]
        bool isRefreshing;

        [ObservableProperty]
        ObservableCollection<Blog> blogs;
       

        [RelayCommand]
        private async void OnRefreshing()
        {
            IsRefreshing = true;

            try
            {
                await LoadDataAsync();
            }
            finally
            {
                IsRefreshing = false;
            }
        }

        public async Task LoadDataAsync()
        {
            // first approch to get 
            //string apiBaseUri = _configuration["ApiUri"];

            // second approch
            ApiConfigurationSetting apiConfigurationSetting = _configuration.GetRequiredSection("ApiSettings").Get<ApiConfigurationSetting>();

            string apiUri = $"{apiConfigurationSetting.ApiUri}/api/blog";

            Blogs = new ObservableCollection<Blog>(await _blogService.GetBlogsAync(apiUri));
        }

        //[RelayCommand]
        //private async void GoToDetail(Blog blog)
        //{
        //    await Shell.Current.GoToAsync($"{nameof(BlogDetailsPage)}?Id={blog.Id}");
        //}

        [RelayCommand]
        private async void GoToDetail(Blog blog)
        {
            await Shell.Current.GoToAsync($"{nameof(BlogDetailsPage)}",true,
                new Dictionary<string, object> { { "Blog", blog } }
                );
        }

        [RelayCommand]
        public async void AddBlog()
        {
            await Shell.Current.GoToAsync(nameof(AddBlogPage));
        }

        [RelayCommand]
        public async void Edit()
        {

        }

        [RelayCommand]
        public async void Delete(Blog blog)
        {
            ApiConfigurationSetting apiConfigurationSetting = _configuration.GetRequiredSection("ApiSettings").Get<ApiConfigurationSetting>();

            string apiUri = $"{apiConfigurationSetting.ApiUri}/api/blog/{blog.Id}";
           await _blogService.DeleteBlogAsnc(apiUri);
            LoadDataAsync();
        }
    }
}
