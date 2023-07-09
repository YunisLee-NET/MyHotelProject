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
        public IActionResult GetAllByİD()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult AddData(T t)
        {
            _genericService.TInsert(t);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteData()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateData()
        {
            return Ok();
        }
    }
}
