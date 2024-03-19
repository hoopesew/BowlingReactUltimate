using APIstuff.Data;
using Microsoft.AspNetCore.Mvc;

namespace APIstuff.Controllers
{
    [Route("[controller]")]
    [ApiController]
    
    public class BowlingLeagueController : ControllerBase
    {
        private IBowlerRepository _teamBowlerRepository;

        public BowlingLeagueController(IBowlerRepository teamBowlerRepository)
        {
            _teamBowlerRepository = teamBowlerRepository;
        }

        [HttpGet("GetTeamBowlers")]
        public IEnumerable<Bowler> GetTeamBowlers()
        {
            var teamBowlers = _teamBowlerRepository.GetTeamBowlers().
                Where(b => b.Team?.TeamName == "Marlins" || b.Team?.TeamName == "Sharks").ToArray();

            return teamBowlers;
        }
    }
}
