using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using dotnetmauiallfeaturedemo.Model;
using dotnetmauiallfeaturedemo.Services;
using dotnetmauiallfeaturedemo.Views;
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
        public MainViewModel(IBlogService blogService)
        {
            _blogService = blogService;
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
            string apiUri = "https://v19qjl2z-5035.asse.devtunnels.ms/api/blog";

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

    }
}
