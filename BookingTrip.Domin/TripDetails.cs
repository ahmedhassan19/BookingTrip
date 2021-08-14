using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTrip.Domin
{
   public class TripDetails
    {
        [Key]
        public int TripId { get; set; }
        public string TripName { get; set; }
        public string CityName { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
        
        

    }
}
