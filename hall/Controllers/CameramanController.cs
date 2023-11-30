using hall.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace hall.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CameramanController : ControllerBase
    {
        private static int i = 3;
        private static DataList cameraman=new DataList();
        // GET: api/<CameramanController>
        [HttpGet]
        public IEnumerable<Cameraman> Get()
        {
            return cameraman.CameramanList;
        }

        // GET api/<CameramanController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var exist = cameraman.CameramanList.Find(c => c.Id == id);
            if (exist == null)
            {
                return NotFound();

            }
            return Ok(exist);
        }

        // POST api/<CameramanController>
        [HttpPost]
        public void Post([FromBody] Cameraman value)
        {
            cameraman.CameramanList.Add(new Cameraman(i++,value.Name,value.NumOfExperience));
        }

        // PUT api/<CameramanController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Cameraman value)
        {
            var exist = cameraman.CameramanList.Find(c => c.Id == id);
            if (exist == null)
            {
                return NotFound();

            }
            exist.Name = value.Name;
            exist.NumOfExperience = value.NumOfExperience;
            return Ok();
        }

        // DELETE api/<CameramanController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var delete = cameraman.CameramanList.Find(c => c.Id == id);
            if (delete == null)
            {
                return NotFound();

            }
            return Ok(cameraman.CameramanList.Remove(delete));
        }
    }
}
