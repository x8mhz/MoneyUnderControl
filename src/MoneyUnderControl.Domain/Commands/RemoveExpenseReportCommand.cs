using System;
using FluentValidation.Results;
using MediatR;

namespace MoneyUnderControl.Domain.Commands
{
    public class RemoveExpenseReportCommand : ExpenseReportCommand, IRequest<ValidationResult>
    {
        public RemoveExpenseReportCommand(Guid id)
        {
            Id = id;
        }
    }
}