using System.ComponentModel.DataAnnotations;

namespace Eduhome.Models
{
    public class Check
    {
        public int Id { get; set; }
        [StringLength(maximumLength:30)]
        public string Name { get; set; }
        public int N { get; set; }
    }
}
