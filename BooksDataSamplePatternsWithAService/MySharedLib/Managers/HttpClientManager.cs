using BooksSample.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MySharedLib.Managers
{
    public class HttpClientManager<T>
    {
        private HttpClient _client;
        public HttpClientManager()
        {
            _client = new HttpClient();
        }

        public async Task<IEnumerable<T>> GetItemsAsync(string url)
        {
            HttpResponseMessage resp = await _client.GetAsync(url);
            resp.EnsureSuccessStatusCode(); // throws exception if error
            string json = await resp.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<IEnumerable<T>>(json);
        }

        public async Task<T> GetItemAsync(string url)
        {
            HttpResponseMessage resp = await _client.GetAsync(url);
            resp.EnsureSuccessStatusCode(); // throws exception if error
            string json = await resp.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(json);
        }
    }

    public class BooksClientManager : HttpClientManager<Book>
    {

    }
}
