using FluentValidation.Results;
using MediatR;
using MoneyUnderControl.Domain.Validations;
using System;

namespace MoneyUnderControl.Domain.Commands
{
    public class RegisterNewExpenseReportCommand : ExpenseReportCommand, IRequest<ValidationResult>
    {
        public RegisterNewExpenseReportCommand(string item, decimal price, DateTime expenseDate, string category, bool status, string description)
        {
            Item = item;
            Price = price;
            ExpenseDate = expenseDate;
            Category = category;
            Status = status;
            Description = description;
        }

        public override bool IsValid()
        {
            ValidationResult = new RegisterNewExpenseReportValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}