using AutoMapper;
using MoneyUnderControl.Application.Interfaces;
using MoneyUnderControl.Application.ViewModels;
using MoneyUnderControl.Domain.Commands;
using MoneyUnderControl.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation.Results;
using MediatR;

namespace MoneyUnderControl.Application.Services
{
    public class ExpenseReportService : IExpenseReportService
    {
        private readonly IMapper _mapper;
        private readonly IExpenseReportRepository _repository;
        private readonly IMediator _mediator;

        public ExpenseReportService(IMapper mapper, IExpenseReportRepository repository, IMediator mediator)
        {
            _mapper = mapper;
            _repository = repository;
            _mediator = mediator;
        }

        public async Task<IEnumerable<ExpenseReportViewModel>> GetAll()
        {
            return _mapper.Map<IEnumerable<ExpenseReportViewModel>>(await _repository.GetAll());
        }

        public async Task<ExpenseReportViewModel> GetById(Guid id)
        {
            return _mapper.Map<ExpenseReportViewModel>(await _repository.GetById(id));
        }

        public async Task<ValidationResult> Register(ExpenseReportViewModel viewModel)
        {
            var register = _mapper.Map<RegisterNewExpenseReportCommand>(viewModel);
            return await _mediator.Send(register);
        }

        public  async Task<ValidationResult> Update(ExpenseReportViewModel viewModel)
        {
            var update = _mapper.Map<UpdateExpenseReportCommand>(viewModel);
            return await _mediator.Send(update);
        }

        public async Task<ValidationResult> Remove(Guid id)
        {
             var remove = new RemoveExpenseReportCommand(id);
             return await _mediator.Send(remove);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}