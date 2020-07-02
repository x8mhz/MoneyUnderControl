using FluentValidation.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MoneyUnderControl.Domain.Entities;
using MoneyUnderControl.Infra.Mappings;

namespace MoneyUnderControl.Infra.Context
{
    public class MoneyUnderControlContext : DbContext
    {
        public MoneyUnderControlContext(DbContextOptions<MoneyUnderControlContext>options) : base(options)
        {

        }

        public DbSet<ExpenseReport> ExpenseReports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MoneyUnderControlDB;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<ValidationResult>();
            modelBuilder.ApplyConfiguration(new ExpenseReportMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}