﻿using System;
using System.Collections.Specialized;
using MediatR;
using MoneyUnderControl.Domain.Entities;


namespace MoneyUnderControl.Domain.Events
{
    public class ExpenseReportRegisteredEvent : INotification
    {
        public ExpenseReportRegisteredEvent(Guid id, string item, decimal price, DateTime expenseDate, string category)
        {
            Id = id;
            Item = item;
            Price = price;
            ExpenseDate = expenseDate;
            Category = category;
        }

        public Guid Id { get; set; }
        public string Item { get; private set; }
        public decimal Price { get; private set; }
        public DateTime ExpenseDate { get; private set; }
        public string Category { get; private set; }
    }
}