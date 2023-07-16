using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelProject.DtoLayer.Dtos.RoomDtos
{
    public class RoomUpdateDto
    {
        public int RoomID { get; set; }

        [Required(ErrorMessage = "Xahis edirik otaq nomresini daxil edin")]
        public string? RoomNumber { get; set; }

        [Required(ErrorMessage = "Xahis edirik otaq fotosunu daxil edin")]
        public string? RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Xahis edirik qiymeti daxil edin")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Xahis edirik otaq basligi melumatini verin")]
        [StringLength(100,ErrorMessage = "Maximum 100 simvol daxil edin")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Xahis edirik yataq sayini qeyd edin")]
        public string? BedCount { get; set; }

        [Required(ErrorMessage = "Xahis edirik hamam sayini qeyd edin")]
        public string? BathCount { get; set; }
        public string? Wifi { get; set; }
        public string? Description { get; set; }
    }
}
