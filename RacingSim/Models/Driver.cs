namespace RacingSim.Models
{
    public class Driver
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal BaseSalaryPerRace { get; set; }
        public int StartLevel { get; set; }
        public int DefaultTeamId { get; set; } = 0;

        public Team Teams { get; set; }
    }
}
