using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using App.Contex;
using App.Enteties;

namespace App.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context) {
            _context = context;
        }
        // CRUD

        // Create
        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] CreateUpdateProductDto dto) {
            var newProduct = new ProductEntity() {
                Brand = dto.Brand,
                Title = dto.Title,
            };
            await _context.Products.AddAsync(newProduct);
            await _context.SaveChangesAsync();

            return Ok("Product Saved Successfully");
        }

        // Read

        // Update

        // Delete
    }
}
