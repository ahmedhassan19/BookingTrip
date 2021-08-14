using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTrip.Application.Features.Reservations.Commands.CreateReservation
{
   public class CreateCommandValidator :  AbstractValidator<CreateReservationCommand>
    {
        public CreateCommandValidator()
        {
            RuleFor(p => p.CreationDate)
                .NotEmpty()
                .NotNull();

            RuleFor(p => p.ReservationDate)
                .NotEmpty()
                .NotNull();
        }
    }
    }

