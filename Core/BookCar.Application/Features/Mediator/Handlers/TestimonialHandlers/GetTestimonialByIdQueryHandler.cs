using BookCar.Application.Features.Mediator.Queries.TestimonialQueries;
using BookCar.Application.Features.Mediator.Results.TestimonialResults;
using BookCar.Application.Interfaces;
using BookCar.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.Mediator.Handlers.TestimonialHandlers
{
    public class GetTestimonialByIdQueryHandler : IRequestHandler<GetTestimonialByIdQuery, GetTestimonialByIdQueryResult>
    {
        private readonly IRepository<Testimonial> _repository;
        public GetTestimonialByIdQueryHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }
        public async Task<GetTestimonialByIdQueryResult> Handle(GetTestimonialByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetTestimonialByIdQueryResult
            {
                TestimonialID = values.TestimonialID,
                Name = values.Name,
                Title = values.Title,
                Comment = values.Comment,
                ImageUrl = values.ImageUrl
            };
        }
    }
}
