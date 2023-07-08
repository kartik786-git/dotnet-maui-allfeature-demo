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
    [QueryProperty(nameof(Id),"Id")]
    [QueryProperty(nameof(Blog), "Blog")]
    public partial class BlogDetailViewModel : BaseViewModel
    {
        private readonly IBlogService _blogService;
        [ObservableProperty]
        int id;

        [ObservableProperty]
        Blog blog;

        //public BlogDetailViewModel(IBlogService blogService)
        //{
        //    _blogService = blogService;
        //}

        //public async Task LoadBlogDataByIdAsync()
        //{
        //  Blog = await _blogService.GetBlogByIdAsync(Id);
        //}

        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }

    }
}
