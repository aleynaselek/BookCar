﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  
using BookCar.Application.Features.Mediator.Results.TagCloudResults;

namespace BookCar.Application.Features.Mediator.Queries.TagCloudQueries
{
    public class GetTagCloudByBlogIdQuery : IRequest<List<GetTagCloudByBlogIdQueryResult>>
    {
        public GetTagCloudByBlogIdQuery(int id)
        {
            Id = id;
        }  
        public int Id { get; set; }
    }
}

