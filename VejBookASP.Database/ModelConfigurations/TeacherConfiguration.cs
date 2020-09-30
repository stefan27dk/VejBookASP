using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace VejBookASP.Database.ModelConfigurations
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Domain.Model.Teacher>
    {
        public void Configure(EntityTypeBuilder<Domain.Model.Teacher> builder)
        {
            builder.HasKey(async => async.Id);
        }
    }
}
