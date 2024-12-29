using System.ComponentModel.DataAnnotations;

namespace Eduhome.Models
{
    public class NoticeBoard
    {
        public int Id { get; set; }
        [StringLength(maximumLength:50)]
        public string Title { get; set; }
        [StringLength(maximumLength: 200)]
        public string Subtitle { get; set; }


    }
}
