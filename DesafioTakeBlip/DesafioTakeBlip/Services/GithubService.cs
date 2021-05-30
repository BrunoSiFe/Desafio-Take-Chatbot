using DesafioTakeBlip.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioTakeBlip.Repository;
using DesafioTakeBlip.Repository.Interface;

namespace DesafioTakeBlip.Services
{
    public class GithubService : Interface.IGithubService
    {

        private readonly IGithubRepository githubRepository = new GithubRepository();

        public Response getRepositories()
        {
            Response responseAPI = new Response();

            string response  = githubRepository.getRespositories();

            return responseAPI;
        }
    }
}
