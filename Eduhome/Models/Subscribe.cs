using System;
using System.ComponentModel.DataAnnotations;

namespace Eduhome.Models
{
    public class Subscribe
    {
        public int Id { get; set; }
        [StringLength(maximumLength:40)]
        public string Email { get; set; }
        public DateTime SubDateTime { get; set; }
    }
}
