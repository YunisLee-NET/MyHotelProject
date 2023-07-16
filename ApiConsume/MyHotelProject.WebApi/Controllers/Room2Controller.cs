using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.DtoLayer.Dtos.RoomDtos;
using MyHotelProject.EntityLayer.Concrete;

namespace MyHotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Room2Controller : GenericDtoController<Room, RoomListDto, RoomUpdateDto, RoomAddDto>
    {
        public Room2Controller(IGenericService<Room> genericService, IMapper mapper) : base(genericService, mapper)
        {
        }
    }
}
