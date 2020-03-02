using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WestPlain.Dtos
{
    public class RegisterDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public string Email { get; set; }
        public BusinessTypeDto BusinessType { get; set; }
        public byte BusinessTypeId { get; set; }
        public string PhoneNumber { get; set; }
    }
}