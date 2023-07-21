using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.EntityLayer.Concrete;

namespace MyHotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : GenericController<Staff>
    {
        private readonly IStaffService _staffService;
        public StaffController(IGenericService<Staff> genericService, IStaffService staffService) : base(genericService)
        {
            _staffService = staffService;
        }

        [HttpGet("staffCount")]
        public async Task<IActionResult> GetStaffCount()
        {
            var staffCount = await _staffService.GetStaffAsync();
            return Ok(staffCount);
        }
        
        //Controller ControllerBaseden miras alinan zaman yazilan kodlar

        //private readonly IStaffService _staffService;

        //public StaffController(IStaffService staffService)
        //{
        //    _staffService = staffService;
        //}

        //[HttpGet]
        //public IActionResult StaffList()
        //{
        //    var values = _staffService.TGetList();
        //    return Ok(values);
        //}
        //[HttpGet("{id}")]
        //public IActionResult GetStaffById()
        //{
        //    return Ok();
        //}

        //[HttpPost]
        //public IActionResult AddStaff(Staff staff)
        //{
        //    _staffService.TInsert(staff);
        //    return Ok();
        //}

        //[HttpDelete]
        //public IActionResult DeleteStaff()
        //{
        //    return Ok();
        //}

        //[HttpPut]
        //public IActionResult UpdateStaff()
        //{
        //    return Ok();
        //}

    }
}
