using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DailyStatus.Models
{
    public class Login
    {
        [RegularExpression("[a-z.A-Z0-9]+@watchguard.com")]
        [Key]
        public string Email { get; set; }

        [MinLength(8)]
        [DataType("Password")]
        public string Password { get; set; }
    }
}