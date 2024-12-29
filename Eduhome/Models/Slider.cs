using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eduhome.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 30)]
        public string TitleFirst { get; set; }
        [StringLength(maximumLength: 30)]
        public string TitleSecond { get; set; }
        [StringLength(maximumLength: 150)]
        public string Subtitle { get; set; }
        public string BtnTxt { get; set; }
        [Required]
        [StringLength(maximumLength:50)]
        public string BgImg { get; set; }
        public int Order { get; set; }

        [NotMapped]
        public IFormFile ImgFile { get; set; }

    }
}
