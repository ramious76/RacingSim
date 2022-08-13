namespace RacingSim.Models
{
    public class Team
    {
        public int Id { get; set; }
        public int SeriesId { get; set; }
        public string TeamName { get; set; }
        public int BaseTeamLevel { get; set; }
        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public Series Series { get; set; }
    }
}
