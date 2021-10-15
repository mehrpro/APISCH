using APISCH.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APISCH.ConfigureEntities
{
    public class CompanyConfigure : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(new Company()
            {
                ID = 1,
                CompanyTitle = "Golrang"
            }, new Company()
            {
                ID = 2,
                CompanyTitle = "ZarinTaj"
            }, new Company()
            {
                ID = 3,
                CompanyTitle = "SepehrCable"
            });
        }
    }
}