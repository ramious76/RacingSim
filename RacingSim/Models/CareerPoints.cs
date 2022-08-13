namespace RacingSim.Models
{
    public class CareerPoints
    {
        public int Id { get; set; }
        public int Place { get; set; }
        public int Points { get; set; }
        public int CareerId { get; set; }
        public Career Career { get; set; }
    }
}
