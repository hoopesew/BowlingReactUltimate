namespace APIstuff.Data
{
    public interface IBowlerRepository
    {
        public IEnumerable<Bowler> Bowlers { get; }
        public IEnumerable<Team> Teams { get; }

        public IEnumerable<Bowler> GetTeamBowlers();
    }
}
