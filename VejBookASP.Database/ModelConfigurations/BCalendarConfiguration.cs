using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VejBookASP.Database.ModelConfigurations
{
    public class BCalendarConfiguration : IEntityTypeConfiguration<Domain.Model.BCalendar>
    {
        public void Configure(EntityTypeBuilder<Domain.Model.BCalendar> builder)
        {
            builder.HasKey(async => async.Id);
        }
    }
}
