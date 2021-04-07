using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Banking.Models
{
    public class LoginAsAdmin
    {
        [Required]
        public string LoginId { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}