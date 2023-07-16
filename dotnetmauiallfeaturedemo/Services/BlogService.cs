using dotnetmauiallfeaturedemo.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetmauiallfeaturedemo.Services
{
    public class BlogService : IBlogService
    {
        private readonly HttpClient _httpClient;
        public BlogService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Blog>> GetBlogsAync(string apiUrl)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
            if (response.IsSuccessStatusCode)
            {
                string reponsecontent = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<Blog>>(reponsecontent);
            }
            else
            {
                // Handle error cases
                Console.WriteLine($"API request failed with status code: {response.StatusCode}");
            }
            return null;

        }


        public Task<Blog> GetBlogByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> PostBlogAync(string url, Blog blog)
        {
            try
            {

                // Serialize the model object to JSON
                var json = JsonConvert.SerializeObject(blog);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Send the HTTP POST request
                var response = await _httpClient.PostAsync(url, content);

                // Check if the request was successful
                if (response.IsSuccessStatusCode)
                {

                    // Process the successful response
                    Console.WriteLine("Data posted successfully");
                    return true;
                }
                else
                {
                    // Process the error response
                    Console.WriteLine($"Error: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                // Handle any exception that occurred during the request
                Console.WriteLine($"Error: {ex.Message}");
            }
            return false;
        }

        public async Task<bool> DeleteBlogAsnc(string apiUri)
        {
            var response = await _httpClient.DeleteAsync(apiUri);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

    }

}
