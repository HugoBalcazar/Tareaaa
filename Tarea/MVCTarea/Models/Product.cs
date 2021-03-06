﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTarea.Models
{
    public enum StatusType
    {
        Activo,
        Inactivo
    }
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }
        public decimal Price { get; set; }

        [Required]
        public StatusType Status { get; set; }
    }
}