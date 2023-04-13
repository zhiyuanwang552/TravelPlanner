using System.ComponentModel.DataAnnotations;

namespace TravelPlanner.Models
{
    public class Cart
    {
        public int CartID { get; set; }
        public float? Total_Price { get; set; }

        public float? Total_Duration { get; set; }

        public List<Plan>? Plans { get; set; }
    }
}
