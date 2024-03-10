using BookCar.Application.Features.CQRS.Commands.CategoryCommands;
using BookCar.Application.Interfaces;
using BookCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler
    {
        private readonly IRepository<Category> _repository;

        public UpdateCategoryCommandHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateCategoryCommand command)
        {
            var values = await _repository.GetByIdAsync(command.CategoryID);
            values.Name = command.Name; 
            
            await _repository.UpdateAsync(values);
        }
    }
}
