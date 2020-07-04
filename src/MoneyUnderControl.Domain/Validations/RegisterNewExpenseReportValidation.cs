using MoneyUnderControl.Domain.Commands;
using System;
using FluentValidation.Results;

namespace MoneyUnderControl.Domain.Validations
{
    public class RegisterNewExpenseReportValidation : ExpenseReportValidation<RegisterNewExpenseReportCommand>
    {
        public RegisterNewExpenseReportValidation()
        {
            ValidateItem();
            ValidatePrice();
            ValidateExpenseDate();
        }

    }
}