using BookCar.Application.Features.Mediator.Commands.ServiceCommands;
using BookCar.Application.Interfaces;
using BookCar.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class UpdateServiceCommandHandler : IRequestHandler<UpdateServiceCommand>
    {
        private readonly IRepository<Service> _repository;

        public UpdateServiceCommandHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateServiceCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.ServiceId);
            values.Title = request.Title;
            values.Description = request.Description;
            values.IconUrl = request.IconUrl;
            await _repository.UpdateAsync(values);
        }
    }
}
