using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTrip.Application.Features.Reservations.Queries.GetReservationsList
{
   public class GetReservationsListQuery : IRequest<List<GetReservationListViewModel>>
    {

    }
}
