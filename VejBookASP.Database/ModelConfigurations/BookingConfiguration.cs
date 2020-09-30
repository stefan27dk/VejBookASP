using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace VejBookASP.Database.ModelConfigurations
{
    public class BookingConfiguration : IEntityTypeConfiguration<Domain.Model.Booking>
    {
        public void Configure(EntityTypeBuilder<Domain.Model.Booking> builder)
        {
            builder.HasKey(async => async.Id);
        }
    }
}
