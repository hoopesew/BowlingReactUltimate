namespace APIstuff.Data
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlingLeagueDatabaseContext _context;

        public EFBowlerRepository(BowlingLeagueDatabaseContext temp)
        {
            _context = temp;
        }

        public IEnumerable<Bowler> Bowlers => _context.Bowlers;
        public IEnumerable<Team> Teams => _context.Teams;

        public IEnumerable<Bowler> GetTeamBowlers()
        {
            var teamBowlers = from bowlers in _context.Bowlers
                              join teams in _context.Teams on bowlers.TeamId equals teams.TeamId
                              select new Bowler
                              {
                                  Team = bowlers.Team,
                                  BowlerFirstName = bowlers.BowlerFirstName,
                                  BowlerLastName = bowlers.BowlerLastName,
                                  BowlerAddress = bowlers.BowlerAddress,
                                  BowlerCity = bowlers.BowlerCity,
                                  BowlerState = bowlers.BowlerState,
                                  BowlerZip = bowlers.BowlerZip,
                                  BowlerPhoneNumber = bowlers.BowlerPhoneNumber,
                              };

            return teamBowlers;
        }
    }
}
