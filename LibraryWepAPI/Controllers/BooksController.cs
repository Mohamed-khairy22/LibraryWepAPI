using LibraryWepAPI.Models;
using LibraryWepAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LibraryWepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        IBookRepsitory bookRepsitory;

        public BooksController(IBookRepsitory bookRepsitory)
        {
            this.bookRepsitory = bookRepsitory;
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
           List<Boook> boooks= bookRepsitory.GetAll();
            return Ok(boooks);
        }
        [HttpGet("{id:int}",Name ="BookDetails")]
        public IActionResult GetBook(int id)
        {
            Boook book = bookRepsitory.GetById(id);
            return Ok(book);
        }
        [HttpPost]
        public IActionResult PostBook([FromBody] Boook book)
        {
            if (ModelState.IsValid)
            {
                 bookRepsitory.Add(book);
                string url= Url.Link("BookDetails", new { id = book.Id });
                return Created(url, book);
            }
            return BadRequest(ModelState);
        }
        [HttpPut("{id:int}")]
        public IActionResult PutBook([FromRoute] int id, [FromBody] Boook book)
        {
            try
            {
                bookRepsitory.Update(id, book);
                return StatusCode(StatusCodes.Status204NoContent);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        public IActionResult DeleteBook(int id)
        {
            bookRepsitory.remove(id);
            return StatusCode(StatusCodes.Status204NoContent);
        }
    }
}
