using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Eduhome.Models
{
    public class CategoryC
    {
        public int Id { get; set; }
        [StringLength(maximumLength:60)] 
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
    }
}
