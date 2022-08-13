namespace RacingSim.Models
{
    public class CareerTeams
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public int CurrentTeamLevel { get; set; }
        public int CareerId { get; set; }

        public Team Teams { get; set; }
        public Career Career { get; set; }

    }
}
