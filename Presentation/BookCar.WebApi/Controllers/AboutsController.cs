using BookCar.Application.Features.CQRS.Commands.AboutCommands;
using BookCar.Application.Features.CQRS.Handlers.AboutHandlers;    
using Microsoft.AspNetCore.Mvc; 
using BookCar.Application.Features.CQRS.Queries.AboutQueries;

namespace BookCar.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly CreateBannerCommandHandler _createAboutCommandHandler;
        private readonly GetBannerByIdQueryHandler _getAboutByIdQueryHandler;
        private readonly GetBannerQueryHandler _getAboutQueryHandler;
        private readonly UpdateBannerCommandHandler _updateAboutCommandHandler;
        private readonly RemoveBannerCommandHandler _removeAboutCommandHandler;

        public AboutsController(CreateBannerCommandHandler createAboutCommandHandler, GetBannerByIdQueryHandler getAboutByIdQueryHandler, GetBannerQueryHandler getAboutQueryHandler, UpdateBannerCommandHandler updateAboutCommandHandler, RemoveBannerCommandHandler removeAboutCommandHandler)
        {
            _createAboutCommandHandler = createAboutCommandHandler;
            _getAboutByIdQueryHandler = getAboutByIdQueryHandler;
            _getAboutQueryHandler = getAboutQueryHandler;
            _updateAboutCommandHandler = updateAboutCommandHandler;
            _removeAboutCommandHandler = removeAboutCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> AboutList()
        {
            var values = await _getAboutQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAbout(int id)
        {
            var value = await _getAboutByIdQueryHandler.Handle(new GetAboutByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateBannerCommand command)
        {
            await _createAboutCommandHandler.Handle(command);
            return Ok("Hakkında Bilgisi Eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveAbout(int id)
        {
            await _removeAboutCommandHandler.Handle(new RemoveAboutCommand(id));
            return Ok("Hakkında Bilgisi Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAbout(UpdateBannerCommand command)
        {
            await _updateAboutCommandHandler.Handle(command);
            return Ok("Hakkında Bilgisi Gğncellendi");
        }

    }
}
