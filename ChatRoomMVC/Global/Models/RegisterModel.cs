using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Global.Models
{
    public class RegisterModel
    {
        [Required]
        public string Name { get; set; }
        //public int Age { get; internal set; }
        //public string Password { get; internal set; }
    }
}