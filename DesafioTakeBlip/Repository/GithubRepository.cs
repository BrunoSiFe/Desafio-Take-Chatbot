using DesafioTakeBlip.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTakeBlip.Repository
{
    public class GithubRepository : Interface.IGithubRepository
    {
        string IGithubRepository.getRespositories()
        {
            throw new NotImplementedException();
        }
    }
}
