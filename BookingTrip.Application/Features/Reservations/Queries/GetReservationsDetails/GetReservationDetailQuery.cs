using MediatR;
using System;

namespace BookingTrip.Application.Features.Reservations.Queries.GetReservationsDetails
{
   public class GetReservationDetailQuery :IRequest<GetReservationDetailViewModel>
    {
        public int ReservationId { get; set; }
    }
}
