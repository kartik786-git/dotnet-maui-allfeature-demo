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
        Task<IEnumerable<Blog>> GetBlogsAync();

        Task<Blog> GetBlogByIdAsync(int Id);
    }
}
