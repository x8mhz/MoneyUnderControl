using System;
using System.Data;
using FluentValidation;
using MoneyUnderControl.Domain.Commands;

namespace MoneyUnderControl.Domain.Validations
{
    public class ExpenseReportValidation<T> : AbstractValidator<T> where T : ExpenseReportCommand
    {
        protected void ValidateId()
        {
            RuleFor(x => x.Id)
                .NotEqual(Guid.Empty);
        }

        protected void ValidateItem()
        {
            RuleFor(x => x.Item)
                .NotEmpty().WithMessage("Item inválido")
                .Length(2, 100).WithMessage("Item deve conter entre 100 e 2 caracteres");
        }

        protected void ValidatePrice()
        {
            RuleFor(x => x.Price)
                .NotEmpty().WithMessage("Valor obrigatório")
                .GreaterThan(0).WithMessage("Valor inválido");
        }

        protected void ValidateExpenseDate()
        {
            RuleFor(x => x.ExpenseDate)
                .NotEmpty().WithMessage("Data do gasto obrigatório");
        }

        protected void ValidateCategory()
        {
            RuleFor(x => x.Category)
                .NotEmpty().WithMessage("Categoria obrigatório");
        }
    }
}