﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Quanli.Models
{
    public class Trainer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name ="Birth Day")]
        public DateTime? BOD { get; set; }
        public string Email { get; set; }
    }
}