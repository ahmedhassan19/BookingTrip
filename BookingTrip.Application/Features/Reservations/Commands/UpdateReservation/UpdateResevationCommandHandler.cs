using AutoMapper;
using BookingTrip.Application.Contracts;
using BookingTrip.Domin;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookingTrip.Application.Features.Reservations.Commands.UpdateReservation
{
    class UpdateResevationCommandHandler: IRequestHandler<UpdateReservationCommand>
    {
        private readonly IAsyncRepository<ReservationTable> _asyncRepository;
        private readonly IMapper _mapper;
        private readonly IReservationRepository _reservationRepository;

        public UpdateResevationCommandHandler(IReservationRepository reservationRepository, IAsyncRepository<ReservationTable> asyncRepository ,IMapper mapper)
        {
            _asyncRepository = asyncRepository;
            _mapper = mapper;
            _reservationRepository = reservationRepository;
        }

        public async Task<Unit> Handle(UpdateReservationCommand request, CancellationToken cancellationToken)
        {
            var reservationObj = await _reservationRepository.GetReservationByIdAsync(request.Id);
            if (reservationObj != null)
            {
                ReservationTable reservation = _mapper.Map<ReservationTable>(request);

                await _asyncRepository.UpdateAsync(reservation);

                return Unit.Value;
            }
           throw new Exception("Reservation Id not found");


        }
    }
}
