using System;
using APISCH.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APISCH.ConfigureEntities
{
    public class ImportExportConfigure : IEntityTypeConfiguration<ImportExport>
    {
        public void Configure(EntityTypeBuilder<ImportExport> builder)
        {
            builder.HasData(new ImportExport()
            {
                ID = 1,
                ImportExportType = true,
                IsActive = true,
                RegisterTime = DateTime.Now,
                TagID = "110A02EF1250"
            },
                new ImportExport()
                {
                    ID = 2,
                    ImportExportType = false,
                    IsActive = true,
                    RegisterTime = DateTime.Now,
                    TagID = "1125A0252DF123"

                });
        }
    }
}