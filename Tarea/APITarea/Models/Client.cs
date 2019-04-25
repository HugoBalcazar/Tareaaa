using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APITarea.Models
{
    public enum StatusTypeC
    {
        Activo,
        Inactivo
    }
    public class Client
    {
        [Key]
        public int ClientId { get; set; }

        [Required]
        public string Name { get; set; }
        public string Mail { get; set; }

        [Required]
        public StatusTypeC Status { get; set; }
    }
}