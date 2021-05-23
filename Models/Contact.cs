using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EZCourse.Models
{
    public partial class Contact
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        [Url]
        public string Site { get; set; }
         
        [Required]
        [StringLength(500)]
        public string Message { get; set; }
         
    }
    
}