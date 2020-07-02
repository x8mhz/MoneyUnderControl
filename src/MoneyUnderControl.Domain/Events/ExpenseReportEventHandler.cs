using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MoneyUnderControl.Domain.Events
{
    public class ExpenseReportEventHandler :
        INotificationHandler<ExpenseReportRegisteredEvent>,
        INotificationHandler<ExpenseReportUpdateEvent>,
        INotificationHandler<ExpenseReportRemovedEvent>
    {
        public Task Handle(ExpenseReportUpdateEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(ExpenseReportRegisteredEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(ExpenseReportRemovedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

    }
}