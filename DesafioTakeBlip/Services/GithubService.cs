using DesafioTakeBlip.Domain;
using DesafioTakeBlip.Repository;
using DesafioTakeBlip.Repository.Interface;
using System.Collections.Generic;
using System.Text.Json;

namespace DesafioTakeBlip.Services
{
    public class GithubService : Interface.IGithubService
    {

        private readonly IGithubRepository githubRepository = new GithubRepository();

        public Response getRepositories()
        {
            Response responseAPI = new Response();

            string response  = githubRepository.getRespositories();

            var data = JsonSerializer.Deserialize<List<GithubRepositories>>(response, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });


            var iteration = 1;

            data.Sort((x, y) => x.created_at.CompareTo(y.created_at));

            foreach (GithubRepositories githubRepositories in data)
            {
                if (githubRepositories.language=="C#")
                {
                    var githubData = new GithubData();

                    switch (iteration) {
                        case 1:
                            githubData.description = githubRepositories.description;
                            githubData.nome = githubRepositories.name;
                            githubData.url = githubRepositories.url;
                            responseAPI.firstRepository = githubData;
                            iteration++;
                            break;
                        case 2:
                            githubData.description = githubRepositories.description;
                            githubData.nome = githubRepositories.name;
                            githubData.url = githubRepositories.url;
                            responseAPI.secondRepository = githubData;
                            iteration++;
                            break;
                        case 3:
                            githubData.description = githubRepositories.description;
                            githubData.nome = githubRepositories.name;
                            githubData.url = githubRepositories.url;
                            responseAPI.thirdRepository = githubData;
                            iteration++;
                            break;
                        case 4:
                            githubData.description = githubRepositories.description;
                            githubData.nome = githubRepositories.name;
                            githubData.url = githubRepositories.url;
                            responseAPI.fourthRepository = githubData;
                            iteration++;
                            break;
                        case 5:
                            githubData.description = githubRepositories.description;
                            githubData.nome = githubRepositories.name;
                            githubData.url = githubRepositories.url;
                            responseAPI.fifthRespository = githubData;
                            iteration++;
                            break;
                        default:
                            iteration++;
                            break;

                    }

                }
            }

            return responseAPI;
        }
    }
}
