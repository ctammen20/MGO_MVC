using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace MGO_MVC.Models
{
    public class Sale
    {
        [Required]
        public int SaleId { get; set; }

        public DateTime SaleDate { get; set; }

        public DateTime SaleTime { get; set; }

        public int EmployeeId { get; set; }

        [ValidateNever]
        public Employee Employee { get; set; }

        public int CustomerId { get; set; }

        [ValidateNever]

        public Customer Customer { get; set; }

        [ValidateNever]
        public ICollection<SaleItem> SaleItems { get; set; }
    }
}
