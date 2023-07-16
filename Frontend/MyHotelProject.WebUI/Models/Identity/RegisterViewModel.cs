﻿using System.ComponentModel.DataAnnotations;

namespace MyHotelProject.WebUI.Models
{
    public class RegisterViewModel
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Username { get; set; }
        public string? Mail { get; set; }
        public string? Password { get; set; }

        [Compare("Password",ErrorMessage ="Shifreler eyni deyildir")]
        public string? PasswordConfirm { get; set; }
    }
}
