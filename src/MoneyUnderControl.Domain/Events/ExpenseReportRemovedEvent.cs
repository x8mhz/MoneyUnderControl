using System;
using MediatR;

namespace MoneyUnderControl.Domain.Events
{
    public class ExpenseReportRemovedEvent : INotification
    {
        public ExpenseReportRemovedEvent(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}