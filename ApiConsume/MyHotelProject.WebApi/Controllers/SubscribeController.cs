﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.EntityLayer.Concrete;

namespace MyHotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : GenericController<Subscribe>
    {
        public SubscribeController(IGenericService<Subscribe> genericService) : base(genericService)
        {
        }
    }
}
