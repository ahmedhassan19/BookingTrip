using AutoMapper;
using BookingTrip.Application.Contracts;
using BookingTrip.Application.Features.Reservations.Queries.GetReservationsList;
using BookingTrip.Domin;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookingTrip.Application.Features.Reservations.Commands.CreateReservation
{
   public class CreateReservationCommandHandler : IRequestHandler<CreateReservationCommand,int>
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly IMapper _mapper;

        public CreateReservationCommandHandler(IReservationRepository reservationRepository,IMapper mapper)
        {
            _reservationRepository = reservationRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateReservationCommand request, CancellationToken cancellationToken)
        {
            ReservationTable reservation = _mapper.Map<ReservationTable>(request);

            CreateCommandValidator validator = new CreateCommandValidator();
            var result = await validator.ValidateAsync(request);

            if (result.Errors.Any())
            {
                throw new Exception("Post is not valid");
            }

            reservation = await _reservationRepository.AddAsync(reservation);

            return reservation.Id;
        }
    }
    }

