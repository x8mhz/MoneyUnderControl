using System;
using MediatR;

namespace MoneyUnderControl.Domain.Events
{
    public class ExpenseReportUpdateEvent : INotification
    {
        public ExpenseReportUpdateEvent(Guid id, string item, decimal price, DateTime expenseDate, string category)
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