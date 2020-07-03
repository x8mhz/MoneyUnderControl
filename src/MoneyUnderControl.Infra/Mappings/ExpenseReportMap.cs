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
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Price)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(x => x.ExpenseDate)
                .IsRequired();

            builder.Property(x => x.ReleaseDate)
                .IsRequired();

            builder.Property(x => x.Category)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Status)
                .IsRequired();

            builder.Property(x => x.Description);
        }
    }
}