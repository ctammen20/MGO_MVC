using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace MGO_MVC.Models
{
    public class Purchase
    {
        [Required]
        public int PurchaseId { get; set; }

        public DateTime PurchaseDate { get; set; }

        public int EmployeeId { get; set; }

        [ValidateNever]
        public Employee Employee { get; set; }

        [ValidateNever]
        public ICollection<PurchaseItem> PurchaseItems { get; set; }

    }
}
