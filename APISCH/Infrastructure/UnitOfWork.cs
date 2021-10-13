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


        public ImportExportRepository ImportExportRepository
        {
            get
            {
                if (_importExportRepository == null)
                {
                    _importExportRepository = new ImportExportRepository(db);
                }
                return _importExportRepository;
            }
        }

        public PersonRepository PersonRepository
        {
            get
            {
                if (_personRepository == null)
                {
                    _personRepository = new PersonRepository(db);
                }

                return _personRepository;
            }
        }


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
