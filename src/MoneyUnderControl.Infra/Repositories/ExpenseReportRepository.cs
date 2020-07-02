using MoneyUnderControl.Domain.Entities;
using MoneyUnderControl.Domain.Interfaces;
using MoneyUnderControl.Infra.Context;

namespace MoneyUnderControl.Infra.Repositories
{
    public class ExpenseReportRepository : RepositoryBase<ExpenseReport>, IExpenseReportRepository
    {
        public ExpenseReportRepository(MoneyUnderControlContext context) : base(context)
        {
        }
    }
}