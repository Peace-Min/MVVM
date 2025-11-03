using Encyc.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encyc.Services
{
    public class ApiService
    {
        private HttpClient _httpClient;
        private ApiResponse _apiResponse;

        public ApiService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<ApiResponse> GetEncycAsync(string query)
        {
            var url = $"https://openapi.naver.com/v1/search/encyc?query={query}";
            var clientId = "Xey45f4WPI_WYex_gN_b";
            var clientSecret = "ZCQmvfKPSh";

            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add("X-Naver-Client-Id", clientId);
            request.Headers.Add("X-Naver-Client-Secret", clientSecret);

            var response = await _httpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                _apiResponse = JsonConvert.DeserializeObject<ApiResponse>(json);
            }

            return _apiResponse;
        }
    }
}
