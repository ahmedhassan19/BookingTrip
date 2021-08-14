using BookingTrip.Application.Features.Reservations.Commands.CreateReservation;
using BookingTrip.Application.Features.Reservations.Commands.DeleteReservation;
using BookingTrip.Application.Features.Reservations.Commands.UpdateReservation;
using BookingTrip.Application.Features.Reservations.Queries.GetReservationsDetails;
using BookingTrip.Application.Features.Reservations.Queries.GetReservationsList;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingTrip.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : Controller
    {
        private readonly IMediator _mediator;

        public ReservationController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpGet("all", Name = "GetAllPosts")]
        public async Task<ActionResult<List<GetReservationListViewModel>>> GetAllPosts()
            {
            var dtos = await _mediator.Send(new GetReservationsListQuery());
            //return Ok(dtos);
                return Ok(dtos);
            
        }
       
        [HttpGet("{id}", Name = "GetPostById")]

        public async Task<ActionResult<GetReservationDetailViewModel>> GetPostById(int id)
        {
            var getEventDetailQuery = new GetReservationDetailQuery() { ReservationId = id };
            return Ok(await _mediator.Send(getEventDetailQuery));
        }

      
        [HttpPost(Name = "AddPost")]
        public async Task<ActionResult<int>> Create([FromBody] CreateReservationCommand CreateReservationCommand)
        {
            int id = await _mediator.Send(CreateReservationCommand);
            return Ok(id);
        }

        
        [HttpPut(Name = "UpdatePost")]
        public async Task<ActionResult> Update([FromBody] UpdateReservationCommand updateReservationCommand)
        {
            await _mediator.Send(updateReservationCommand);
            return NoContent();
        }

        
        [HttpDelete("{id}", Name = "DeletePost")]
        public async Task<ActionResult> Delete(int id)
        {
            var deleteReservationCommand = new DeleteReservationCommand() { ReservationId = id };
            await _mediator.Send(deleteReservationCommand);
            return NoContent();
        }
    }
}
