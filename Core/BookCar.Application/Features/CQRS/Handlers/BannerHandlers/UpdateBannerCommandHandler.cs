using BookCar.Application.Features.CQRS.Commands.BannerCommands;
using BookCar.Application.Interfaces;
using BookCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class UpdateBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;

        public UpdateBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateBannerCommand command)
        {
            var values = await _repository.GetByIdAsync(command.BannerId);
            values.Description = command.Description;
            values.Title = command.Title;
            values.VideoDescription = command.VideoDescription;
            values.VideoUrl = command.VideoUrl;
            
            await _repository.UpdateAsync(values);
        }
    }
}
