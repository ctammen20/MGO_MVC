using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace MGO_MVC.Models
{
    public class PurchaseItem
    {
        [Required]
        public int PurchaseId { get; set; }

        [Required]
        public int ItemId { get; set; }

        public int PurchaseQty { get; set; }

        [ValidateNever]
        public Purchase Purchase { get; set; }

        [ValidateNever]
        public Item Item { get; set; }

    }
}
