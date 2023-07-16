using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyHotelProject.BusinessLayer.Abstract;
using System.Runtime.CompilerServices;

namespace MyHotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericDtoController<T, ListDto, UpdateDto, AddDto> : ControllerBase where T : class
    {
        private readonly IGenericService<T> _genericService;
        private readonly IMapper _mapper;

        public GenericDtoController(IGenericService<T> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult AllList()
        {
            var values = _genericService.TGetList();
            var mapData = _mapper.Map<List<ListDto>>(values);
            return Ok(mapData);
        }
        [HttpGet("{id}")]
        public IActionResult GetListByID(int id)
        {
            var values = _genericService.TGetByID(id);
            var mapData = _mapper.Map<List<ListDto>>(values);
            return Ok(mapData);
        }
        [HttpPost]
        public IActionResult AddData(AddDto dto)
        {
            //_genericService.TInsert(dto);
            if (!ModelState.IsValid)
            {
                return BadRequest(dto);
            }
            var mapData=_mapper.Map<T>(dto);
            _genericService.TInsert(mapData);
            return Ok(mapData);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteData(int id)
        {
            var data = _genericService.TGetByID(id);
            _genericService.TDelete(data);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateData(UpdateDto dto)
        {
            var mapData = _mapper.Map<T>(dto);
            _genericService.TUpdate(mapData);
            return Ok();
        }
    }
}
