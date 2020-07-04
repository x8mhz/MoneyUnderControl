using AutoMapper;
using FluentValidation.Results;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MoneyUnderControl.Application.AutoMapperConfig;
using MoneyUnderControl.Application.Interfaces;
using MoneyUnderControl.Application.Services;
using MoneyUnderControl.Domain.Commands;
using MoneyUnderControl.Domain.Interfaces;
using MoneyUnderControl.Infra.Context;
using MoneyUnderControl.Infra.Repositories;

namespace MoneyUnderControl.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(x => x.AddProfile<MappingProfile>(), typeof(Startup));

            services.AddMediatR(typeof(Startup));

            services.AddScoped<IExpenseReportService, ExpenseReportService>();

            services.AddScoped<IRequestHandler<RegisterNewExpenseReportCommand, ValidationResult>, ExpenseReportCommandHandler>();
            services.AddScoped<IRequestHandler<UpdateExpenseReportCommand, ValidationResult>, ExpenseReportCommandHandler>();
            services.AddScoped<IRequestHandler<RemoveExpenseReportCommand, ValidationResult>, ExpenseReportCommandHandler>();

            services.AddScoped<IExpenseReportRepository, ExpenseReportRepository>();

            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddDbContext<MoneyUnderControlContext>();

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
