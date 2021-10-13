using System;
using System.Threading.Tasks;
using APISCH.Services.Repositories;
using Microsoft.EntityFrameworkCore;

namespace APISCH.Infrastructure
{
    public interface IUnitOfWork<TContext> : IDisposable where TContext : DbContext
    {
        //1-Begin TransAction  2-Commit(SaveChange) 3-RollBack
        ImportExportRepository ImportExportRepository { get; } //Read Only
        PersonRepository PersonRepository { get; }
        void Commit();
        Task<int> CommitAsync();


    }
}
