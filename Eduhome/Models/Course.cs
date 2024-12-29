using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Eduhome.Models
{
    public class Course
    {
        public int Id { get; set; }
        public int? CategoryCId{ get; set; }
        [StringLength(maximumLength:50)]
        [Required]
        public string Name { get; set; }
        [StringLength(maximumLength: 500)]
        public string Desc { get; set; }
        [StringLength(maximumLength: 40)]
        [Required]
        public string Img { get; set; }
        [StringLength(maximumLength: 250)]
        public string AboutCourse { get; set; }
        [StringLength(maximumLength: 300)]
        public string HowToApply { get; set; }
        [StringLength(maximumLength: 300)]
        public string Certification { get; set; }
        public string StartTime { get; set; }
        public int Duration { get; set; }
        public int ClassDuration { get; set; }
        public string Language { get; set; }
        public int StudentCount { get; set; }
        public int Price { get; set; }
        public CategoryC CategoryC { get; set; }
        public List<CourseTag> CourseTags { get; set; }
    }
}
