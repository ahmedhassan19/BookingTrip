using BookingTrip.Application.Contracts;
using BookingTrip.Domin;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTrip.Persistence.Repositories
{
    class ReservationRepository : BaseRepository<ReservationTable>, IReservationRepository
    {
        public ReservationRepository(DataContext postDbContext) : base(postDbContext)
        {

        }

        public async Task<IReadOnlyList<ReservationTable>> GetAllReservationAsync()
        {
            List<ReservationTable> allReservation = new List<ReservationTable>();
            allReservation = await _dbContext.reservations.ToListAsync();
            return allReservation;
        }

        public async Task<ReservationTable> GetReservationByIdAsync(int id)
        {
            ReservationTable reservation = new ReservationTable();
            reservation= await GetByIdAsync(id);
            return reservation;
            
        }
    }
}
