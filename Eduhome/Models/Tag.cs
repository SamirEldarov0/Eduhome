using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Eduhome.Models
{
    public class Tag
    {
        public int Id { get; set; }
        [StringLength(maximumLength:30)]
        public string Name { get; set; }
        public List<CourseTag> CourseTags { get; set; }
    }
}
