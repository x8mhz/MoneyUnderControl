using FluentValidation.Results;
using MediatR;
using MoneyUnderControl.Domain.Validations;
using System;

namespace MoneyUnderControl.Domain.Commands
{
    public class RemoveExpenseReportCommand : ExpenseReportCommand, IRequest<ValidationResult>
    {
        public RemoveExpenseReportCommand(Guid id)
        {
            Id = id;
        }

        public override bool IsValid()
        {
            ValidationResult = new RemoveExpenseReportValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}