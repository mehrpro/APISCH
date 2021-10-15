using System;
using System.Threading.Tasks;
using APISCH.Services.Repositories;
using Microsoft.EntityFrameworkCore;

namespace APISCH.Infrastructure
{
    public class UnitOfWork<TContext> : IUnitOfWork<TContext> where TContext : DbContext, new()

    {
        private readonly DbContext db;
        private ImportExportRepository _importExportRepository;
        private PersonRepository _personRepository;
        private CompanyRepository _companyRepository;

        public UnitOfWork()
        {
            db = new TContext();
        }



        public void Commit()
        {
            db.SaveChanges();
        }

        public Task<int> CommitAsync()
        {
            return db.SaveChangesAsync();
        }


        public ImportExportRepository ImportExportRepository => _importExportRepository ?? (_importExportRepository = new ImportExportRepository(db));

        public PersonRepository PersonRepository => _personRepository ?? (_personRepository = new PersonRepository(db));

        public CompanyRepository CompanyRep => _companyRepository ?? (_companyRepository = new CompanyRepository(db));


        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }




    }
}
