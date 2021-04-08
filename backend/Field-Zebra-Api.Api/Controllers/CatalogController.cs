using Microsoft.AspNetCore.Mvc;
using Field.Zebra.Domain.Catalog;
using System.Collections.Generic;

namespace Field.Zebra.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetItems()
        {
            var items = new List<Item>()
            {
                new Item("Shirt", "Ohio State shirt.", "Nike", 29.99m),
                new Item("Shorts", "Ohio State shorts.", "Nike", 44.99m)
            };
        return Ok(items);
        }
    }
    

}