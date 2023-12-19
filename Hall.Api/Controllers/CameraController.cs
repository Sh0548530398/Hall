
using Hall.Core.Entities;
using Hall.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace hall.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CameramanController : ControllerBase
    {
        private readonly ICameraService _cameraService;

        public CameramanController(ICameraService cameraService)
        {
            _cameraService = cameraService;
        }

        // GET: api/<CameramanController>
        [HttpGet]
        public IEnumerable<Cameraman> Get()
        {
            return _cameraService.GetAllList();
        }

        // GET api/<CameramanController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Cameraman camera= _cameraService.GetById(id);
            if (camera == null)
            {
                return NotFound();

            }
            return Ok(camera);
        }

        // POST api/<CameramanController>
        [HttpPost]
        public void Post([FromBody] Cameraman value)
        {
            _cameraService.PostCameraman(value);
        }

        // PUT api/<CameramanController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Cameraman value)
        {
            bool flag = _cameraService.PutCameraman(id,value);
            if (flag)
                return Ok();
            return NotFound();
        }

        // DELETE api/<CameramanController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            bool flag = _cameraService.DeleatCameraman(id);
            if (flag)
                return Ok();
            return NotFound();
        }
    }
}