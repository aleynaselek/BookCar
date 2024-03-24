﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using BookCar.Application.Features.Mediator.Results.BlogResults;

namespace BookCar.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetBlogByIdQuery :IRequest<GetBlogByIdQueryResult>
    {
        public GetBlogByIdQuery(int id)
        {
            Id = id;
        }  
        public int Id { get; set; }
    }
}
