using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AWSLambdaApi.Controllers;
using AWSLambdaApi.Models;
using Xunit;

namespace AWSLambdaApi.Tests
{
    public class TeamsControllerTest
    {
         TeamsController controller = new TeamsController();

        [Fact]
        public void QueryTeamListReturnsCorrectTeams()
        {
            List<Team> teams = new List<Team>(controller.GetAllTeams());
            Assert.Equal(teams.Count, 2);

        }
    }
}
