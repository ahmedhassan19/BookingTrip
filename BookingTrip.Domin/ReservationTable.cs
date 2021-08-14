using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTrip.Domin
{
    public class ReservationTable
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("TripId")]
        public int TripId { get; set; }
        [ForeignKey("ResreverdByCustomerId")]
        public int ResreverdByCustomerId { get; set; }

        public string CustomerName { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime CreationDate { get; set; }
        public string Note { get; set; }




    }
}
