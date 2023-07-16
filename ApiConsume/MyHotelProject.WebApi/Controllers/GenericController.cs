using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.EntityLayer.Concrete;

namespace MyHotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T> : ControllerBase where T : class
    {
        private readonly IGenericService<T> _genericService;

        public GenericController(IGenericService<T> genericService)
        {
            _genericService = genericService;
        }

        [HttpGet]
        public IActionResult AllList()
        {
            var values = _genericService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetAllByID(int id)
        {
            var values = _genericService.TGetByID(id);
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddData(T t)
        {
            _genericService.TInsert(t);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteData(int id)
        {
            var values = _genericService.TGetByID(id);
            _genericService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateData(T t)
        {
            _genericService.TUpdate(t);
            return Ok();
        }
    }
}
