using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Eduhome.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [StringLength(maximumLength:30)]
        [Required]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 30)]
        public string Position { get; set; }
        [StringLength(maximumLength: 400)]
        public string AboutMe { get; set; }
        [StringLength(maximumLength: 70)]
        public string Degree { get; set; }
        public int Experience { get; set; }
        [StringLength(maximumLength: 40)]
        [Required]
        public string Email { get; set; }
        [StringLength(maximumLength: 40)]
        public string PhoneNumber { get; set; }
        [StringLength(maximumLength: 30)]
        [Required]
        public string Img { get; set; }
        public List<TeacherSkill> TeacherSkills { get; set; }


    }
}
