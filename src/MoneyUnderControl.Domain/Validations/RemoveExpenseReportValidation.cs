using MoneyUnderControl.Domain.Commands;

namespace MoneyUnderControl.Domain.Validations
{
    public class RemoveExpenseReportValidation : ExpenseReportValidation<RemoveExpenseReportCommand>
    {
        public RemoveExpenseReportValidation()
        {
            ValidateId();
        }
    }
}