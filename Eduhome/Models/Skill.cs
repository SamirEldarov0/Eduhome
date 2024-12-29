using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Eduhome.Models
{
    public class Skill
    {
        public int Id { get; set; }
        [StringLength(maximumLength:30)]
        public string Name { get; set; }
        public List<TeacherSkill> TeacherSkills { get; set; }
    }
}
