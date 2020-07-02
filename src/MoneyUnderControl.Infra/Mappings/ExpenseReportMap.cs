using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoneyUnderControl.Domain.Entities;

namespace MoneyUnderControl.Infra.Mappings
{
    public class ExpenseReportMap : IEntityTypeConfiguration<ExpenseReport>
    {
        public void Configure(EntityTypeBuilder<ExpenseReport> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Item)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(x => x.Price)
                .IsRequired();

            builder.Property(x => x.ExpenseDate)
                .IsRequired();

            builder.Property(x => x.Category)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}