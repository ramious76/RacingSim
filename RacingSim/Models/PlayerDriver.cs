namespace RacingSim.Models
{
    public class PlayerDriver
    {
        public int Id { get; set; }
        public int DriverId { get; set; }
        public int Xp { get; set; }
        public decimal CurrentSalary { get; set; }
        public int CurrentLevel { get; set; }

        public Driver Drivers { get; set; }
    }
}
