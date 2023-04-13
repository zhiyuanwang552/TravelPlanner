using System.ComponentModel.DataAnnotations;

namespace TravelPlanner.Models
{
    public class Destination
    {
        public int DestinationID { get; set; }
        public string? Province { get; set; }
        public string? City { get; set; }

        public List<Plan>? Plans { get; set; }

    }
}
