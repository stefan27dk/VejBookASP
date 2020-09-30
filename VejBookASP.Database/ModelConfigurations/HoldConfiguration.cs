using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace VejBookASP.Database.ModelConfigurations
{
    public class HoldConfiguration : IEntityTypeConfiguration<Domain.Model.Hold>
    {
        public void Configure(EntityTypeBuilder<Domain.Model.Hold> builder)
        {
            builder.HasKey(async => async.Id);
        }
    }
}
