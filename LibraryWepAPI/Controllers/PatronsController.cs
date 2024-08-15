using LibraryWepAPI.Models;
using LibraryWepAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryWepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatronsController : ControllerBase
    {
        IPatronRepository patronRepsitory;
        public PatronsController(IPatronRepository patronRepsitory)
        {
            this.patronRepsitory = patronRepsitory;
        }

        [HttpGet]
        public IActionResult GetPatrons()
        {
            List<Patron> patrons = patronRepsitory.GetAll();
            return Ok(patrons);
        }
        [HttpGet("{id:int}", Name = "PatronDetails")]
        public IActionResult GetPatron(int id)
        {
            Patron patron = patronRepsitory.GetById(id);
            return Ok(patron);
        }
        [HttpPost]
        public IActionResult PostPatron([FromBody] Patron patron)
        {
            if (ModelState.IsValid)
            {
                patronRepsitory.Add(patron);
                string url = Url.Link("PatronDetails", new { id = patron.Id });
                return Created(url, patron);
            }
            return BadRequest(ModelState);
        }
        [HttpPut("{id:int}")]
        public IActionResult PutPatron([FromRoute] int id, [FromBody] Patron patron)
        {
            try
            {
                patronRepsitory.Update(id, patron);
                return StatusCode(StatusCodes.Status204NoContent);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        public IActionResult DeletePatron(int id)
        {
            patronRepsitory.remove(id);
            return StatusCode(StatusCodes.Status204NoContent);
        }
    }
}
