using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace OxyApi
{
    class Program
    {
        static async Task Main()
        {
            const string Username = "YOUR_USERNAME";
            const string Password = "YOUR_PASSWORD";

            var parameters = new Dictionary<string, string>()
            {
                { "source", "universal" },
                { "url", "https://www.fiverr.com/categories/programming-tech?source=category_tree&utm_source=google&utm_medium=cpc-brand&utm_campaign=g_row-en_brand&utm_term=one-fiverr_(exact)&utm_content=adid^553700574654^keyword^fiverr^placement^^device^c&caid=406997588&agid=33518326868&ad_id=553700574654&kw=fiverr&lpcat=br_general&show_join=true&gad_source=1&gclid=cj0kcqiayewrbhddarisagp1mwtihv9kyf30tagb9bqxwvo1eydzfxza0qti9_idtnirpiou_htg1wwaal19ealw_wcb"},
            }


            var client = new HttpClient();

            Uri baseUri = new Uri("https://realtime.oxylabs.io");
            client.BaseAddress = baseUri;

            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "/v1/queries");
            requestMessage.Content = JsonContent.Create(parameters);

            var authenticationString = $"{Username}:{Password}";
            var base64EncodedAuthenticationString = Convert.ToBase64String(System.Text.ASCIIEncoding.UTF8.GetBytes(authenticationString));
            requestMessage.Headers.Add("Authorization", "Basic " + base64EncodedAuthenticationString);

            var response = await client.SendAsync(requestMessage);
            var contents = await response.Content.ReadAsStringAsync();

            Console.WriteLine(contents);
        }
    }
}