using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCar.Application.Features.Mediator.Results.BlogResults;
using BookCar.Application.Features.Mediator.Queries.BlogQueries;
using BookCar.Application.Interfaces;
using BookCar.Domain.Entities;
using BookCar.Application.Interfaces.BlogInterfaces;

namespace BookCar.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogByAuthorIdQueryHandler : IRequestHandler<GetBlogByAuthorIdQuery, List<GetBlogByAuthorIdQueryResult>>
    {
        private readonly IBlogRepository _repository;

        public GetBlogByAuthorIdQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBlogByAuthorIdQueryResult>> Handle(GetBlogByAuthorIdQuery request, CancellationToken cancellationToken)
        {           
            var values = _repository.GetBlogsByAuthorId(request.Id);             
            return values.Select(x => new GetBlogByAuthorIdQueryResult
            {
                BlogID = x.BlogID, 
                AuthorID = x.AuthorID,
                AuthorName = x.Author.Name,    
                AuthorDescription = x.Author.Description,
                AuthorImageUrl = x.Author.ImageUrl
            }).ToList();
        }
    }
} 