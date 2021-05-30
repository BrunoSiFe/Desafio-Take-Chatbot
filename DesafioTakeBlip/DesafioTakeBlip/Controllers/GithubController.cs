using DesafioTakeBlip.Services;
using DesafioTakeBlip.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTakeBlip.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GithubController : ControllerBase
    {
        private readonly IGithubService githubService = new GithubService();

        [HttpGet]
        public IActionResult getRepositories()
        {

            var result = githubService.getRepositories();
            
            return Ok(result);
        }

    }
}
