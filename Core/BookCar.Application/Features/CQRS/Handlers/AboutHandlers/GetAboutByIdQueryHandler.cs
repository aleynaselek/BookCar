﻿using BookCar.Application.Features.CQRS.Queries.AboutQueries;
using BookCar.Application.Features.CQRS.Results.AboutResults;
using BookCar.Application.Interfaces;
using BookCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class GetBannerByIdQueryHandler
    {
        private readonly IRepository<About> _repository;
        public GetBannerByIdQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }
        public async Task<GetBannerByIdQueryResult> Handle(GetBannerByIdQuery query)
        {
            var values =await _repository.GetByIdAsync(query.Id);
            return new GetBannerByIdQueryResult
            {
                AboutID = values.AboutID,
                Description = values.Description,
                Title = values.Title,
                ImageUrl = values.ImageUrl
            };
        }
    }
}
