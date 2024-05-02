﻿using BookCar.Application.Features.RepositoryPattern;
using BookCar.Domain.Entities;
using BookCar.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Persistence.Repositories.CommentRepositories
{
    public class CommentRepository<T> : IGenericRepository<Comment>
    {

        private readonly CarBookContext _context;
        public CommentRepository(CarBookContext context)
        {
            _context = context;
        }
        public void Create(Comment entity)
        {
            _context.Comments.Add(entity);
            _context.SaveChanges();
        }

        public List<Comment> GetAll()
        {
           return _context.Comments.Select(x=> new Comment
           {
               CommentID = x.CommentID,
               Name = x.Name,
               CreatedDate = x.CreatedDate,
               Description = x.Description,
               BlogId = x.BlogId   
           }).ToList();
        }

        public Comment GetById(int id)
        {
           return _context.Comments.Find(id);
        }

        public void Remove(Comment entity)
        {
            _context.Comments.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(Comment entity)
        {
           _context.Comments.Update(entity);
           _context.SaveChanges();
        }
    }
}
