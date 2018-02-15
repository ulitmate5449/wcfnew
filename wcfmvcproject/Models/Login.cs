using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace wcfmvcproject.Models
{
    public class Login
    {
        [Required]
        public string ename { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public int pswd { get; set; }
    }
}