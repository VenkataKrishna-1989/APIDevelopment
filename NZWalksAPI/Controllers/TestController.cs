using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZWalksAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("FetchProducts")]
        public IActionResult FetchProducts()
        {
            return Ok(new { ProductId = 1,Name="TV",Category="Electronics" } );
        }
        [HttpGet("FetchProductsById/{id}")]
        public IActionResult FetchProducts(int id)
        {
            return Ok("New Product from id is:"+id);
        }
    }
}
