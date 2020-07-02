using System;
using System.ComponentModel.DataAnnotations;

namespace MoneyUnderControl.Application.ViewModels
{
    public class ExpenseReportViewModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Item { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public DateTime ExpenseDate { get; set; }
        [Required]
        public string Category { get; set; }
    }
}