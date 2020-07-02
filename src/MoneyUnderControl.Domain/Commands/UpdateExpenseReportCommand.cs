﻿using System;
using FluentValidation.Results;
using MediatR;

namespace MoneyUnderControl.Domain.Commands
{
    public class UpdateExpenseReportCommand : ExpenseReportCommand, IRequest<ValidationResult>
    {
        public UpdateExpenseReportCommand(Guid id, string item, decimal price, DateTime expenseDate, string category)
        {
            Id = id;
            Item = item;
            Price = price;
            ExpenseDate = expenseDate;
            Category = category;
        }
    }
}