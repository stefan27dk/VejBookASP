using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace VejBookASP.Database.ModelConfigurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Domain.Model.Student>
    {
        public void Configure(EntityTypeBuilder<Domain.Model.Student> builder)
        {
            builder.HasKey(async => async.Id);
            builder.HasKey(async => async.FirstName);
            builder.HasKey(async => async.LastName);
        }
    }
}
