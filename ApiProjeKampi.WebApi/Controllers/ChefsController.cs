using ApiProjeKampi.WebApi.Context;
using ApiProjeKampi.WebApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChefsController : ControllerBase
    {
        private readonly ApiContext _context;

        public ChefsController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet]

        public IActionResult ChefsList()
        {
            var values = _context.Chefs.ToList();
            return Ok(values);
        }
        
        [HttpPost]
        public IActionResult CreateChef(Chef chef)
        {
            _context.Chefs.Add(chef);
            _context.SaveChanges();
            return Ok("şef sisteme eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteChef(int id)
        { 
            var values = _context.Chefs.Find(id);
            _context.Chefs.Remove(values);
            _context.SaveChanges();
            return Ok("silme işlemi gerçekleşti");
        }
        [HttpGet("GetChef")]
        public IActionResult GetChef(int id)
        {
            return Ok(_context.Chefs.Find(id));
        }
        [HttpPut]
        public IActionResult UpdateChef(Chef chef)
        {
            _context.Chefs.Update(chef);
            _context.SaveChanges();
            return Ok("şef güncelleme işlemi başarılı");       
        }


    }
}
