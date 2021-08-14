using AutoMapper;
using BookingTrip.Application.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookingTrip.Application.Features.Reservations.Queries.GetReservationsList
{
   public class GetReservationsListQueryHandler: IRequestHandler<GetReservationsListQuery,List<GetReservationListViewModel>>
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly IMapper _mapper;
        public GetReservationsListQueryHandler(IReservationRepository reservationRepository, IMapper mapper)
        {
            _reservationRepository = reservationRepository;
            _mapper = mapper;
        }

        public async Task<List<GetReservationListViewModel>> Handle(GetReservationsListQuery request, CancellationToken cancellationToken)
        {
            
            var allResevations = await _reservationRepository.GetAllReservationAsync();
            if (allResevations != null)
            {
                return _mapper.Map<List<GetReservationListViewModel>>(allResevations);
            }
            throw new Exception("Reservation Id not found");
        }

        
    }
}
