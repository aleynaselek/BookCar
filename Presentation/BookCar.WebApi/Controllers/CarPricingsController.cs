using Microsoft.AspNetCore.Mvc;
using MediatR;
using BookCar.Application.Features.Mediator.Queries.PricingQueries;
using BookCar.Application.Features.Mediator.Commands.PricingCommands;
using BookCar.Application.Features.Mediator.Queries.CarPricingQueries;

namespace BookCar.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarPricingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarPricingsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetCarPricingWithCarList()
        {
            var values = await _mediator.Send(new GetCarPricingWithCarQuery());
            return Ok(values);
        }

      
    }
}
