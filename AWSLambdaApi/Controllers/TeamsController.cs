using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AWSLambdaApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AWSLambdaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        public TeamsController()
        {
        }
        [HttpGet]
        public IEnumerable<Team> GetAllTeams()
        {
            return new Team[] { new Team("one"), new Team("two") };

        }

    }
}