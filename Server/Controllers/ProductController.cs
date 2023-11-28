using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlazorECommerceApp.Server.Data;

namespace BlazorECommerceApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public ProductController(DataContext context)
        {
            _dataContext = context;                
        }
        [HttpGet]
        public async Task<ActionResult<IList<Product>>> GetProduct()
        {
            var products= await _dataContext.Products.ToListAsync();
            return Ok(products);
        }
    }
}
