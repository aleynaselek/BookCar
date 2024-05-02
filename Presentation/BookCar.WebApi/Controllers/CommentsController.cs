

using BookCar.Application.Features.RepositoryPattern;
using BookCar.Domain.Entities;
using Microsoft.AspNetCore.Mvc;  

namespace BookCar.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly IGenericRepository<Comment> _commentsRepository; 

        public CommentsController(IGenericRepository<Comment> commentsRepository)
        {
            _commentsRepository = commentsRepository; 
        }

        [HttpGet]
        public IActionResult CommentList()
        {
            var values =  _commentsRepository.GetAll();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetComment(int id)
        {
            var value =  _commentsRepository.GetById(id);
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateComment(Comment command)
        {
             _commentsRepository.Create(command);
            return Ok("Hakkında Bilgisi Eklendi");
        }

        [HttpDelete]
        public IActionResult RemoveComment(int id)
        {
            var value = _commentsRepository.GetById(id);
            _commentsRepository.Remove(value);
            return Ok("Hakkında Bilgisi Silindi");
        }

        [HttpPut]
        public IActionResult UpdateComment(Comment command)
        {
            _commentsRepository.Update(command);
            return Ok("Hakkında Bilgisi Güncellendi");
        }

    }
}
