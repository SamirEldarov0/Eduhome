using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Eduhome.Models
{
    public class CategoryE
    {
        public int Id { get; set; }
        [StringLength(maximumLength:30)]
        public string Name { get; set; }
        public List<Event> Events { get; set; }
    }
}
