using System;
using FluentValidation.Results;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using MoneyUnderControl.Domain.Entities;
using MoneyUnderControl.Domain.Interfaces;

namespace MoneyUnderControl.Domain.Commands
{
    public class ExpenseReportCommandHandler : 
        IRequestHandler<RegisterNewExpenseReportCommand, ValidationResult>,
        IRequestHandler<UpdateExpenseReportCommand, ValidationResult>,
        IRequestHandler<RemoveExpenseReportCommand, ValidationResult>
    {
        private readonly IExpenseReportRepository _repository;

        public ExpenseReportCommandHandler(IExpenseReportRepository repository)
        {
            _repository = repository;
        }

        public async Task<ValidationResult> Handle(RegisterNewExpenseReportCommand request, CancellationToken cancellationToken)
        {
            var expense = new ExpenseReport(Guid.NewGuid(), request.Item, request.Price, request.ExpenseDate, DateTime.Now, request.Category, request.Status);

            _repository.Add(expense);

            return new ValidationResult();
        }

        public async Task<ValidationResult> Handle(UpdateExpenseReportCommand request, CancellationToken cancellationToken)
        {
            var expense = new ExpenseReport(request.Id, request.Item, request.Price, request.ExpenseDate, request.ReleaseDate, request.Category, request.Status);

            _repository.Update(expense);

            return new ValidationResult();
        }

        public async Task<ValidationResult> Handle(RemoveExpenseReportCommand request, CancellationToken cancellationToken)
        {
            var expense = new ExpenseReport(request.Id, request.Item, request.Price, request.ExpenseDate, request.ReleaseDate, request.Category, request.Status);

            _repository.Remove(expense);

            return new ValidationResult();
        }
    }
}