﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projeto1TU.Models
{
    public class Estado
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string Nome { get; set; }
    }
}