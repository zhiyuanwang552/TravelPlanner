namespace TravelPlanner.Models
{
    public class Plan
    {
        public int ID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public float? Cost { get; set; }
        public float? Duration { get; set; }
        public string? Related_Pictures { get; set; }
        public int? DestinationID { get; set; }
        public Destination? Destination { get; set; }
        public int? CartID { get; set; }
        public Cart? Cart { get; set; }
    }
}
