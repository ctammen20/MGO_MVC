using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace MGO_MVC.Models
{
    public class SaleItem
    {
        [Required]
        public int ItemId { get; set; }

        [Required]  
        public int SaleId { get; set; }

        public int SaleQtySold { get; set; }

        [ValidateNever]
        public Item Item { get; set; }

        [ValidateNever]
        public Sale Sale { get; set; }

    }
}
