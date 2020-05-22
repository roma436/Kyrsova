using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorApp2.Data
{
    public class UserRegister : IUserRegister
    {
        public HttpClient _httpClient { get; }

        public UserRegister(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task Create(User user)
        {
            if (user == null || user.email == null  || user.password == null || user.passwordConfirm == null)
            {
                return;
            }

            string serializedUser = JsonConvert.SerializeObject(user);

            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "Register");
            requestMessage.Content = new StringContent(serializedUser);

            requestMessage.Content.Headers.ContentType
                = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await _httpClient.SendAsync(requestMessage);

            var responseStatusCode = response.StatusCode;
            var responseBody = await response.Content.ReadAsStringAsync();

            var returnedUser = JsonConvert.DeserializeObject<User>(responseBody);

            var res = await Task.FromResult(returnedUser);
        }
    }
}
