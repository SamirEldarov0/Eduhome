using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Eduhome.Models
{
    public class Speaker
    {
        public int Id { get; set; }
        [StringLength(maximumLength:50)]
        public string Name { get; set; }
        [StringLength(maximumLength: 50)]
        public string Position { get; set; }
        [StringLength(maximumLength: 50)]
        [Required]
        public string Img { get; set; }
        public List<EventSpeaker> EventSpeakers { get; set; }
    }
}
