using System;
using System.ComponentModel.DataAnnotations;

namespace todos_core.Models
{
    public class BaseObject
    {
        [Required]
        public long Id { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        [Required]
        public string CreatedBy { get; set; }
    }
}
