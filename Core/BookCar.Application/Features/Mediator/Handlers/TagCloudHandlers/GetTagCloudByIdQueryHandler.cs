﻿using BookCar.Application.Features.Mediator.Queries.BlogQueries;
using BookCar.Application.Features.Mediator.Queries.TagCloudQueries;
using BookCar.Application.Features.Mediator.Results.BlogResults;
using BookCar.Application.Features.Mediator.Results.TagCloudResults;
using BookCar.Application.Interfaces;
using BookCar.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.Mediator.Handlers.TagCloudHandlers
{
    public class GetTagCloudByIdQueryHandler : IRequestHandler<GetTagCloudByIdQuery, GetTagCloudByIdQueryResult>
    {
        private readonly IRepository<TagCloud> _repository;
        public GetTagCloudByIdQueryHandler(IRepository<TagCloud> repository)
        {
            _repository = repository;
        }
        public async Task<GetTagCloudByIdQueryResult> Handle(GetTagCloudByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            if(values != null)
            { 
            return new GetTagCloudByIdQueryResult
            {
                BlogID = values.BlogID,
                Title = values.Title,
                TagCloudID = values.TagCloudID
            };
            }
            return null;
        }
    }
}
