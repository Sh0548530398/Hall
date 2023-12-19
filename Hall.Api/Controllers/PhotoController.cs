using Hall.Core.Entities;
using Hall.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hall.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoController : ControllerBase
    {
        private readonly IPhotoService _photoService;

        public PhotoController(IPhotoService photoService)
        {
            _photoService = photoService;
        }

        // GET: api/<CameramanController>
        [HttpGet]
        public IEnumerable<Photographer> Get()
        {
            return _photoService.GetAllList();
        }

        // GET api/<CameramanController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Photographer order = _photoService.GetById(id);
            if (order == null)
            {
                return NotFound();

            }
            return Ok(order);
        }

        // POST api/<CameramanController>
        [HttpPost]
        public void Post([FromBody] Photographer value)
        {
            _photoService.PostPhotographer(value);
        }

        // PUT api/<CameramanController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Photographer value)
        {
            bool flag = _photoService.PutPhotographer(id, value);
            if (flag)
                return Ok();
            return NotFound();
        }

        // DELETE api/<CameramanController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            bool flag = _photoService.DeleatPhotographer(id);
            if (flag)
                return Ok();
            return NotFound();
        }
    }
}
