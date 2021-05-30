using DesafioTakeBlip.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace DesafioTakeBlip.Repository
{
    public class GithubRepository : Interface.IGithubRepository
    {

        private const string url = "https://api.github.com/orgs/takenet/repos";
        string IGithubRepository.getRespositories()
        {

            var dataObjects = "";

            var client = new HttpClient();
            client.BaseAddress = new Uri(url);

            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Authorization", "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&");
            client.DefaultRequestHeaders.Add("User-Agent", "BrunoSiFe");
            HttpResponseMessage response = client.GetAsync(url).Result;


            if (response.IsSuccessStatusCode)
            {
                dataObjects = response.Content.ReadAsStringAsync().Result;
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            client.Dispose();

            return dataObjects;
        }
    }
}
