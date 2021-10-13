using APISCH.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APISCH.ConfigureEntities
{
    public class PersonConfigure : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasData(new Person()
            {
                FName = "Farshid",
                LName = "Mohammadi",
                Age = 35,
                PhoneNumber = "9186620474"
            });
        }
    }
}