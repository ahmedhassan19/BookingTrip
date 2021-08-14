using BookingTrip.Domin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTrip.Application.Features.Reservations.Queries.GetReservationsDetails
{
  public  class GetReservationDetailViewModel
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime CreationDate { get; set; }
        public string Note { get; set; }
        public int TripId { get; set; }
        public int ResreverdByCustomerId { get; set; }
    }
}
