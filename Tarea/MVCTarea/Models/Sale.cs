using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTarea.Models
{
    public enum StatusTypeS
    {
        Activo,
        Inactivo
    }
    public class Sale
    {
        [Key]
        public int ProductId { get; set; }
        public int ClientId { get; set; }
        public int SaleId { get; set; }

        [Required]
        public string Date { get; set; }

        [Required]
        public StatusTypeS Status { get; set; }
    }
}