using BookingTrip.Domin;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTrip.Application.Features.Reservations.Commands.CreateReservation
{
    public class CreateReservationCommand :IRequest<int>
    {
        public string CustomerName { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime CreationDate { get; set; }
        public int TripId { get; set; }
        public int ResreverdByCustomerId { get; set; }
        public string Note { get; set; }
    }
}
