using Microsoft.AspNetCore.Mvc;
using Field.Zebra.Domain.Catalog;
using System.Collections.Generic;
using Field_Zebra_Api.Data;

namespace Field.Zebra.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        private readonly StoreContext _db;

        public CatalogController(StoreContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult GetItems()
        {  
            return Ok(_db.Items);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetItem(int id) 
        {
            var item = _db.Items.Find(id);
            if (item == null)
            {
                return Ok(_db.Items.Find(id));
            }

            return Ok();
        }

        [HttpPost]
        public IActionResult Post(Item item)
        {
            return Created("/catalog/42", item);
        }

        [HttpPost("{id:int}/ratings")]
        public IActionResult PostRating(int id, [FromBody] Rating rating)
        {
            var item = new Item("Shirt", "Ohio State shirt.", "Nike", 29.99m);
            item.ID = id;
            item.AddRating(rating);

            return Ok(item);
        }

        [HttpPut("{id:int}")]
        public IActionResult PutItem(int id, [FromBody] Item item)
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteItem(int id)
        {
            return Ok();
        }

    }
    

}