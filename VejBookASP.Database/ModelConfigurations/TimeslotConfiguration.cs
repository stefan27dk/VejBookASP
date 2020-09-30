using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace VejBookASP.Database.ModelConfigurations
{
    public class Timeslotonfiguration : IEntityTypeConfiguration<Domain.Model.Timeslot>
    {
        public void Configure(EntityTypeBuilder<Domain.Model.Timeslot> builder)
        {
            builder.HasKey(async => async.Id);
        }
    }
}
