using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Hand_in_1.Models;

namespace Hand_in_1.Data
{
    public class AdultApiService : IAdultData
    {
        private string uri = "https://localhost:5004";

        private readonly HttpClient client;

        public AdultApiService()
        {
            client = new HttpClient();
        }


        public async Task<IList<Person>> getAdult()
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync("https://localhost:5004/Adult");

            string result = await responseMessage.Content.ReadAsStringAsync();

            List<Person> adults = JsonSerializer.Deserialize<List<Person>>(result, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase

            });
            return adults;
        }

        public async Task AddAdultAsync(Person adult)
        {
            using HttpClient client = new HttpClient();

            Person adults = new()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Sten",
                HairColor = "Brown",
                EyeColor = "Brown",
                Age = 26,
                Weight = 70,
                Height = 186,
                Sex = "Male"
            };

            string adultAsJson = JsonSerializer.Serialize(adults);
            StringContent content = new StringContent(
                adultAsJson,
                Encoding.UTF8,
                "application/json"
            );
            HttpResponseMessage response = await client.PostAsync("https://localhost:5004/Adult", content);
            if (!response.IsSuccessStatusCode)
                throw new Exception($@"Error: {response.StatusCode}, {response.ReasonPhrase}");



        }

        public async Task RemoveAdultAsync(int id)
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.DeleteAsync("https://localhost:5004/Adult/{id}");
            if (!response.IsSuccessStatusCode)
                throw new Exception(@"Error: {response.StatusCode}, {response.ReasonPhrase}");

        }
    }
}

