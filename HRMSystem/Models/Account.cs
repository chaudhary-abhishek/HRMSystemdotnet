using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using BAL;
using System.ComponentModel.DataAnnotations;

namespace HRMSystem.Models
{
    public class Account
    {
        [Display(Name ="Enter User ID")]
        public int id { get; set; }

        public string Password { get; set; }
    }
}