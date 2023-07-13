using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using dotnetmauiallfeaturedemo.Model;
using dotnetmauiallfeaturedemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetmauiallfeaturedemo.ViewModels
{
    public partial class AddBlogViewModel : BaseViewModel
    {
        public AddBlogViewModel(IBlogService blogService)
        {
            _blogService = blogService;
            Blog = new Blog();
        }

        [ObservableProperty]
        string failError;

        [ObservableProperty]
        Blog blog;

        private readonly IBlogService _blogService;

        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }

        [RelayCommand]
        async Task Save()
        {
            //var blog = Blog.Name;
            string baseURI = $"https://v19qjl2z-5035.asse.devtunnels.ms/api/blog";
            bool isCreated = await _blogService.PostBlogAync(baseURI, Blog);
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
