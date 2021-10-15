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
                PhoneNumber = "9186620474",
                CompanyID_FK = 1

            },
            new Person
            {
                FName = "Sara",
                LName = "Mohammadi",
                Age = 10,
                PhoneNumber = "9372515252",
                CompanyID_FK = 2,

            },
            new Person()
            {
                FName = "Sepehr",
                LName = "Mohammadi",
                CompanyID_FK = 2
                ,
                Age = 6,
                PhoneNumber = "9382362525"
            });
        }
    }
}