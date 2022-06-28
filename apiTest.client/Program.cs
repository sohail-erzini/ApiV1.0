// See https://aka.ms/new-console-template for more information


using apiTest.client;
using System.Net.Http.Json;

HttpClient client = new();
client.BaseAddress = new Uri("http://localhost:7013");

// specifiying response format
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

// retrieving all users

HttpResponseMessage response = await client.GetAsync("api/User");

response.EnsureSuccessStatusCode();

if (response.IsSuccessStatusCode)
{
    // deserialize the content of the response ( JSON ) into IEnumerable of users details
    var users = await response.Content.ReadFromJsonAsync<IEnumerable<UserDto>>();

  foreach(var user in users)
    {
        Console.WriteLine(user.username);
    }
}
else { Console.WriteLine("No Result"); }

Console.ReadLine();