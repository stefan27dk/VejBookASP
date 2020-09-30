using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VejBookASP.Domain.Model;

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
