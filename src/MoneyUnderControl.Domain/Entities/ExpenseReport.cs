using System;

namespace MoneyUnderControl.Domain.Entities
{
    public class ExpenseReport
    {
        protected ExpenseReport()
        {
            
        }

        public ExpenseReport(Guid id, string item, decimal price, DateTime expenseDate, string category)
        {
            Id = id;
            Item = item;
            Price = price;
            ExpenseDate = expenseDate;
            Category = category;
        }

        public Guid Id { get;  set; }
        public string Item { get;  set; }
        public decimal Price { get;  set; }
        public DateTime ExpenseDate { get;  set; }
        public string Category { get;  set; }
    }
}