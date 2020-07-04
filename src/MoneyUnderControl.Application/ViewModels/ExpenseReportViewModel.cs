using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MoneyUnderControl.Application.ViewModels
{
    public class ExpenseReportViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        [StringLength(100, ErrorMessage = "Entre 100 e 2 caracteres ")]
        [DisplayName("Item")]
        public string Item { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        [DisplayName("Valor")]
        [DataType(DataType.Currency, ErrorMessage = "Valor inválido")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        [DisplayName("Data")]
        public DateTime ExpenseDate { get; set; }

        [DisplayName("Data de Lançamento")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        [DisplayName("Tipo de Gasto")]
        public string Category { get; set; }

        [DisplayName("Status")]
        public bool Status { get; set; }

        [DisplayName("Descrição")]
        public string Description { get; set; }
    }
}