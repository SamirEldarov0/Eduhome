using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Eduhome.Models
{
    public class Event
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }//dbda CategoryEId var
        public DateTime EventDate { get; set; }
        [StringLength(maximumLength:30)]
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [StringLength(maximumLength: 50)]
        public string Venue { get; set; }
        [StringLength(maximumLength: 350)]
        public string Desc { get; set; }
        [StringLength(maximumLength: 50)]
        [Required]
        public string Img { get; set; }
        public int CategoryEId { get; set; }
        public CategoryE CategoryE { get; set; }
        public List<EventSpeaker> EventSpeakers { get; set; }

    }
}
