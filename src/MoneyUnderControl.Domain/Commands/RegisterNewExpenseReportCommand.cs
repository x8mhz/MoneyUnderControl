﻿using System;
using FluentValidation.Results;
using MediatR;

namespace MoneyUnderControl.Domain.Commands
{
    public class RegisterNewExpenseReportCommand : ExpenseReportCommand, IRequest<ValidationResult>
    {
        public RegisterNewExpenseReportCommand(string item, decimal price, DateTime expenseDate, string category)
        {
            Item = item;
            Price = price;
            ExpenseDate = expenseDate;
            Category = category;
        }
    }
}