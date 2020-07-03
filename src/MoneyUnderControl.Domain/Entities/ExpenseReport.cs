using System;

namespace MoneyUnderControl.Domain.Entities
{
    public class ExpenseReport
    {
        protected ExpenseReport()
        {
            // required by EF
        }

        public ExpenseReport(Guid id, string item, decimal price, DateTime expenseDate, DateTime releaseDate, string category, bool status)
        {
            Id = id;
            Item = item;
            Price = price;
            ExpenseDate = expenseDate;
            ReleaseDate = releaseDate;
            Category = category;
            Status = status;
        }

        public Guid Id { get;  private set; }
        public string Item { get;  private set; }
        public decimal Price { get;  private set; }
        public DateTime ExpenseDate { get;  private set; }
        public DateTime  ReleaseDate { get; private set; }
        public string Category { get;  private set; }
        public bool Status { get; private set; }
        public string Description { get; private set; }

        public void DescriptionCreate(string description)
        {
            Description = description;
        }
    }
}