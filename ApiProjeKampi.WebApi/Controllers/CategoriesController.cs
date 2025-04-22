using ApiProjeKampi.WebApi.Context;
using ApiProjeKampi.WebApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ApiContext _context;
        public CategoriesController(ApiContext context)
        {
            _context = context;
            
        }
        [HttpGet]
        public IActionResult CategoryList()
        {
            var values = _context.Categories.ToList();
            return Ok(values);
        }


        [HttpPost] // ekleme işlemleri için kullanılır
        public IActionResult CreateCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return Ok("kategori ekleme işlemi başarılı");
        }

        [HttpDelete]
        public IActionResult DeleteCategory(int id) 
        {
            var value = _context.Categories.Find(id);
            _context.Categories.Remove(value);
            _context.SaveChanges();
            return Ok("kategori silme işlemi başarılı");
        }
        [HttpGet("GetCategory")] //aynı atrribute kullanamazsın o yüzden bir parantez açılır
        public IActionResult GetCategory(int id) //metotun dönüş türü IActionResult türünde olduğundan dolayı return Ok(value) yazıyoruz
        {
            var values = _context.Categories.Find(id);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
            return Ok("kategori güncelleme işlemi başarılı");
        }


    }
}
