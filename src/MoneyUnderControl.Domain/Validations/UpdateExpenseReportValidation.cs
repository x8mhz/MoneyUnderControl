using MoneyUnderControl.Domain.Commands;
using System;
using FluentValidation.Results;

namespace MoneyUnderControl.Domain.Validations
{
    public class UpdateExpenseReportValidation : ExpenseReportValidation<UpdateExpenseReportCommand>
    {
        public UpdateExpenseReportValidation()
        {
            ValidateId();
            ValidateItem();
            ValidatePrice();
            ValidateExpenseDate();
            ValidateCategory();
        }
    }
}