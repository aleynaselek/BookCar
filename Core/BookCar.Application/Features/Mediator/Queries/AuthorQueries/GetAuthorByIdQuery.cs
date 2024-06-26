﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using BookCar.Application.Features.Mediator.Results.AuthorResults;

namespace BookCar.Application.Features.Mediator.Queries.AuthorQueries
{
    public class GetAuthorByIdQuery :IRequest<GetAuthorByIdQueryResult>
    {
        public GetAuthorByIdQuery(int id)
        {
            Id = id;
        }  
        public int Id { get; set; }
    }
}
