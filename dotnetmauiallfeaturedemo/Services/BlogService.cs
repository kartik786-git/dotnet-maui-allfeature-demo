using dotnetmauiallfeaturedemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetmauiallfeaturedemo.Services
{
    public class BlogService : IBlogService
    {
        private readonly List<Blog> _blogList;

        public BlogService()
        {
            _blogList = new List<Blog>()
             { new Blog() { Name="C#" ,
                Description = "C# - My Name is kartik and you are waching my youtube channel here we will how we can easy develop app in a smart way so that we can deliver fast to our client",
                ImageUrl="https://kartik786-git.github.io/TestStaticPage/Courses/visual studio.PNG"},
            new Blog() { Name="Maui" ,
                Description = "Maui - My Name is kartik and you are waching my youtube channel here we will how we can easy develop app in a smart way so that we can deliver fast to our client" ,
                ImageUrl = "https://kartik786-git.github.io/TestStaticPage/Courses/dotnet maui.PNG"},
            new Blog() { Name="Angular" ,
                Description = "Angular - My Name is kartik and you are waching my youtube channel here we will how we can easy develop app in a smart way so that we can deliver fast to our client" ,
                ImageUrl="https://kartik786-git.github.io/TestStaticPage/Courses/architecture.PNG" },
            new Blog() { Name="web api" ,
                Description = "web api - My Name is kartik and you are waching my youtube channel here we will how we can easy develop app in a smart way so that we can deliver fast to our client",
                ImageUrl="https://kartik786-git.github.io/TestStaticPage/Courses/asp.net core.PNG"},
            new Blog() { Name="EF" ,
                Description = "EF - My Name is kartik and you are waching my youtube channel here we will how we can easy develop app in a smart way so that we can deliver fast to our client" ,
                ImageUrl="https://kartik786-git.github.io/TestStaticPage/Courses/csharp.PNG"}
            };
        }
        public async Task<IEnumerable<Blog>> GetBlogsAync()
        {
            return _blogList;
        }
    }
}
