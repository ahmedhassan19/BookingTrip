using AutoMapper;
using BookingTrip.Application.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookingTrip.Application.Features.Reservations.Queries.GetReservationsDetails
{
    public class GetReservationDetailQueryHandlerIRequestHandler: IRequestHandler<GetReservationDetailQuery, GetReservationDetailViewModel>
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly IMapper _mapper;

        public GetReservationDetailQueryHandlerIRequestHandler(IReservationRepository reservationRepository,IMapper mapper)
        {
            _reservationRepository = reservationRepository;
            _mapper = mapper;
        }

        public async Task<GetReservationDetailViewModel> Handle(GetReservationDetailQuery request, CancellationToken cancellationToken)
        {
            var reservation = await _reservationRepository.GetReservationByIdAsync(request.ReservationId);
            if (reservation != null)
            {
                return _mapper.Map<GetReservationDetailViewModel>(reservation);
            }
            throw new Exception("Reservation Id not found");
        }
    }
}
