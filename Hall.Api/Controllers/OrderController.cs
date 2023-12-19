using Hall.Core.Entities;
using Hall.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hall.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        private readonly IOrderService _orderService;

        public global::Holl.UnitTest.DataContextFake Context { get; }

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public OrderController(global::Holl.UnitTest.DataContextFake context)
        {
            Context = context;
        }

        // GET: api/<CameramanController>
        [HttpGet]
        public IEnumerable<Orders> Get()
        {
            return _orderService.GetAllList();
        }

        // GET api/<CameramanController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Orders order = _orderService.GetById(id);
            if (order == null)
            {
                return NotFound();

            }
            return Ok(order);
        }

        // POST api/<CameramanController>
        [HttpPost]
        public void Post([FromBody] Orders value)
        {
            _orderService.PostOrders(value);
        }

        // PUT api/<CameramanController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Orders value)
        {
            bool flag = _orderService.PutOrders(id, value);
            if (flag)
                return Ok();
            return NotFound();
        }

        // DELETE api/<CameramanController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            bool flag = _orderService.DeleatOrders(id);
            if (flag)
                return Ok();
            return NotFound();
        }
    }
}
