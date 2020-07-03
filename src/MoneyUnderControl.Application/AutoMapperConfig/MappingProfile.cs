using AutoMapper;
using MoneyUnderControl.Application.ViewModels;
using MoneyUnderControl.Domain.Commands;
using MoneyUnderControl.Domain.Entities;

namespace MoneyUnderControl.Application.AutoMapperConfig
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Domain to ViewModel
            CreateMap<ExpenseReport, ExpenseReportViewModel>();

            // ViewModel to Domain
            CreateMap<ExpenseReportViewModel, RegisterNewExpenseReportCommand>().ConstructUsing(x =>
                new RegisterNewExpenseReportCommand(x.Item, x.Price, x.ExpenseDate, x.Category, x.Status));

            CreateMap<ExpenseReportViewModel, UpdateExpenseReportCommand>().ConstructUsing(x =>
                new UpdateExpenseReportCommand(x.Id, x.Item, x.Price, x.ExpenseDate, x.Category, x.Status));
        }
    }
}
