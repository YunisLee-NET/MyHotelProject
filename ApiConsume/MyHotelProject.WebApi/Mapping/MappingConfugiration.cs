using AutoMapper;
using MyHotelProject.DtoLayer.Dtos.AboutDtos;
using MyHotelProject.DtoLayer.Dtos.RoomDtos;
using MyHotelProject.DtoLayer.StaffDtos;
using MyHotelProject.EntityLayer.Concrete;

namespace MyHotelProject.WebApi.Mapping
{
    public class MappingConfugiration:Profile
    {
        public MappingConfugiration()
        {
            CreateMap<Staff, StaffListDto>().ReverseMap();
            CreateMap<Staff, StaffAddDto>().ReverseMap();
            CreateMap<Staff, StaffUpdateDto>().ReverseMap();

            CreateMap<Room, RoomListDto>().ReverseMap();
            CreateMap<Room, RoomAddDto>().ReverseMap();
            CreateMap<Room, RoomUpdateDto>().ReverseMap();

            CreateMap<About,AboutListDto>().ReverseMap();
            CreateMap<About,AboutAddDto>().ReverseMap();
            CreateMap<About,AboutUpdateDto>().ReverseMap();
        }
    }
}
