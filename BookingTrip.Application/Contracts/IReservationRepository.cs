using BookingTrip.Application.Features.Reservations.Queries.GetReservationsDetails;
using BookingTrip.Domin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTrip.Application.Contracts
{
    public interface IReservationRepository : IAsyncRepository<ReservationTable>
    {
        Task<IReadOnlyList<ReservationTable>> GetAllReservationAsync();
        Task<ReservationTable> GetReservationByIdAsync(int id);

    }
}
