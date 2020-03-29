
using System;
using System.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text;

namespace BlazorMovies.Client.Helpers
{
    class HttpService: IHttpService
    {
        private readonly HttpClient _httpClient;
        public HttpService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<HttpResponseWrapper<Object>> Post<T>(string url, T data)
        {
            var datajson = JsonSerializer.Serialize(data);
            var stringcontent = new StringContent(datajson, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(url, stringcontent);
            return new HttpResponseWrapper<object>(null, response.IsSuccessStatusCode, response);
        }
    }
}
