using System;
using FluentValidation.Results;
using MediatR;
using MoneyUnderControl.Domain.Validations;

namespace MoneyUnderControl.Domain.Commands
{
    public class UpdateExpenseReportCommand : ExpenseReportCommand, IRequest<ValidationResult>
    {
        public UpdateExpenseReportCommand(Guid id, string item, decimal price, DateTime expenseDate, string category, bool status, string description)
        {
            Id = id;
            Item = item;
            Price = price;
            ExpenseDate = expenseDate;
            Category = category;
            Status = status;
            Description = description;
        }

        public override bool IsValid()
        {
            ValidationResult = new UpdateExpenseReportValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}