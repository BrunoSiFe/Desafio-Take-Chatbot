using DesafioTakeBlip.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTakeBlip.Services.Interface
{
    public interface IGithubService
    {
        public Response getRepositories();
    }
}
