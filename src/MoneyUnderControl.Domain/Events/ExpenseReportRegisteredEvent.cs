using System;
using System.Collections.Specialized;
using MediatR;
using MoneyUnderControl.Domain.Entities;


namespace MoneyUnderControl.Domain.Events
{
    public class ExpenseReportRegisteredEvent : INotification
    {
        public ExpenseReportRegisteredEvent(Guid id, string item, decimal price, DateTime expenseDate, DateTime releaseDate, string category, bool status)
        {
            Id = id;
            Item = item;
            Price = price;
            ExpenseDate = expenseDate;
            ReleaseDate = releaseDate;
            Category = category;
            Status = status;
        }

        public Guid Id { get; set; }
        public string Item { get; private set; }
        public decimal Price { get; private set; }
        public DateTime ExpenseDate { get; private set; }
        public DateTime ReleaseDate { get; private set; }
        public string Category { get; private set; }
        public bool Status { get; private set; }
    }
}