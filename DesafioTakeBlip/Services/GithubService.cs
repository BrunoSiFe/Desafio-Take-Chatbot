using DesafioTakeBlip.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTakeBlip.Services
{
    public class GithubService : Interface.IGithubService
    {
        public Response getRepositories()
        {
            Response response = new Response();

            response.totalCount = 1;

            return response;
        }
    }
}
