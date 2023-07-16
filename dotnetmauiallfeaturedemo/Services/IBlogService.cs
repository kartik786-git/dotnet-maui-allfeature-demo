using dotnetmauiallfeaturedemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetmauiallfeaturedemo.Services
{
    public interface IBlogService
    {
        Task<IEnumerable<Blog>> GetBlogsAync(string apiUri);

        Task<Blog> GetBlogByIdAsync(int Id);

        Task<bool> PostBlogAync(string url, Blog blog);

        Task<bool> DeleteBlogAsnc(string apiUri);
    }
}
