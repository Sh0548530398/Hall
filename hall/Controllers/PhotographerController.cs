using hall.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace hall.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotographerController : ControllerBase
    {
        private static int i = 3;
        private static DataList photographer = new DataList();
        // GET: api/<PhotographerController>
        [HttpGet]
        public IEnumerable<Photographer> Get()
        {
            return photographer.PhotographersList;
        }

        // GET api/<PhotographerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {

            var exist = photographer.PhotographersList.Find(p => p.Id == id);
            if (exist == null)
            {
                return NotFound();

            }
            return Ok(exist);
        }

        // POST api/<PhotographerController>
        [HttpPost]
        public void Post([FromBody] Photographer value)
        {
            photographer.PhotographersList.Add(new Photographer(i++, value.Name, value.NumOfExperience));
        }

        // PUT api/<PhotographerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Photographer value)
        {
            var exist = photographer.PhotographersList.Find(p => p.Id == id);
            if (exist == null)
            {
                return NotFound();

            }
            exist.Name = value.Name;
            exist.NumOfExperience = value.NumOfExperience;
            return Ok();
        
        }

        // DELETE api/<PhotographerController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var delete=photographer.PhotographersList.Find(p=>p.Id==id);
            if (delete == null)
            {
                return NotFound();

            }
            return Ok(photographer.PhotographersList.Remove(delete));
        }
    }
}
