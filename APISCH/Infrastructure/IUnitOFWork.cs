using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APISCH.Repositories;

namespace APISCH.Infrastructure
{
    public interface IUnitOfWork<TContext> : IDisposable where TContext : DbContext
    {
        //1-Begin TransAction  2-Commit(SaveChange) 3-RollBack
        ImportExportRepository ImportExportRepository { get; } //Read Only
        void Commit();
        Task<int> CommitAsync();


    }
}
