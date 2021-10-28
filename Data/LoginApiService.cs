using System;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Hand_in_1.Models;

namespace Hand_in_1.Data
{
    public class LoginApiService : IUserService
    {
        public User ValidateUser(string userName, string password)
        {
            throw new System.NotImplementedException();
        }

        public async Task<User> ValidateLogin(string username, string password)
        {
         
            using HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync($"https://localhost:5004/Users?username={username}&password={password}");
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string userAsJson = await response.Content.ReadAsStringAsync();
                User resultUser = JsonSerializer.Deserialize<User>(userAsJson);
                return resultUser;
            } 
            throw new Exception("User not found");   
            
        }
    }
}