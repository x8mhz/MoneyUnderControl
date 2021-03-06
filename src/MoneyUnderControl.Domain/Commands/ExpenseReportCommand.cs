﻿using System;
using FluentValidation.Results;

namespace MoneyUnderControl.Domain.Commands
{
    public abstract class ExpenseReportCommand
    {
        public Guid Id { get; protected set; }
        public string Item { get; protected set; }
        public decimal Price { get; protected set; }
        public DateTime ExpenseDate { get; protected set; }
        public DateTime ReleaseDate { get; protected set; }
        public string Category { get; protected set; }
        public bool Status { get; protected set; }
        public string Description { get; protected set; }

        public ValidationResult ValidationResult { get; set; }
        public abstract bool IsValid();
    }
}