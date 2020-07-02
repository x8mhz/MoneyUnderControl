using MoneyUnderControl.Application.ViewModels;
using System;
using System.Collections.Generic;

using System.Threading.Tasks;
using FluentValidation.Results;

namespace MoneyUnderControl.Application.Interfaces
{
    public interface IExpenseReportService : IDisposable
    {
        Task<IEnumerable<ExpenseReportViewModel>> GetAll();
        Task<ExpenseReportViewModel> GetById(Guid id);
        Task<ValidationResult> Register(ExpenseReportViewModel model);
        Task<ValidationResult> Update(ExpenseReportViewModel model);
        Task<ValidationResult> Remove(Guid id);
    }
}