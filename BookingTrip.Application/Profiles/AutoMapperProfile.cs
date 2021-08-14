using AutoMapper;
using BookingTrip.Application.Features.Reservations.Commands.CreateReservation;
using BookingTrip.Application.Features.Reservations.Commands.DeleteReservation;
using BookingTrip.Application.Features.Reservations.Commands.UpdateReservation;
using BookingTrip.Application.Features.Reservations.Queries.GetReservationsDetails;
using BookingTrip.Application.Features.Reservations.Queries.GetReservationsList;
using BookingTrip.Domin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTrip.Application.Profiles
{
    class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ReservationTable, GetReservationListViewModel>().ReverseMap();
            CreateMap<ReservationTable, GetReservationDetailViewModel>().ReverseMap();
            CreateMap<ReservationTable, CreateReservationCommand>().ReverseMap();
            CreateMap<ReservationTable, DeleteReservationCommand>().ReverseMap();
            CreateMap<ReservationTable, UpdateReservationCommand>().ReverseMap();

        }
    }
}
