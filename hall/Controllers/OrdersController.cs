using hall.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace hall.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private static int i = 3;
        private static DataList orders=new DataList();
        // GET: api/<OrdersControllers>
        [HttpGet]
        public IEnumerable<Orders> Get()
        {
            return orders.OrdersList;
        }

        // GET api/<OrdersControllers>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var exist = orders.OrdersList.Find(o => o.Id == id);
            if (exist == null)
            {
                return NotFound();

            }
            return Ok(exist);
        }

        // POST api/<OrdersControllers>
        [HttpPost]
        public void Post([FromBody] Orders value)
        {
            orders.OrdersList.Add(new Orders(i++, value.Name, value.Descreption, value.Date, value.Price));
        }

        // PUT api/<OrdersControllers>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Orders value)
        {
            var exist=orders.OrdersList.Find(o=>o.Id==id);
            if (exist == null)
            {
                return NotFound();
              
            }
            exist.Name = value.Name;
            exist.Descreption = value.Descreption;
            exist.Date = value.Date;
            exist.Price = value.Price;
            return Ok();
            
        }

        // DELETE api/<OrdersControllers>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var delete=orders.OrdersList.Find(o =>o.Id==id);
            if (delete == null)
            {
                return NotFound();

            }
            return Ok(orders.OrdersList.Remove(delete));
            
        }
    }
}
