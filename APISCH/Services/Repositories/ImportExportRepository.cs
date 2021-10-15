using System.Collections.Generic;
using System.Linq;
using APISCH.Entities;
using APISCH.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace APISCH.Services.Repositories
{
    public interface IImportExportRepository : IRepository<ImportExport>
    {
        //------Definition Private Functions Model -------------//



    }
    public class ImportExportRepository : Repository<ImportExport>, IImportExportRepository
    {

        private readonly DbContext _db;
        public ImportExportRepository(DbContext dbContext) : base(dbContext)
        {
            this._db = (this._db ?? (ApplicationContext)_db);
        }


    }
}
