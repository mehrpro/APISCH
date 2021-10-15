using System;
using System.Collections.Generic;
using System.Linq;
using APISCH.Entities;
using APISCH.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace APISCH.Services.Repositories
{

    public interface ICompanyRepository : IRepository<Company>
    {

    }

    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(DbContext dbContext) : base(dbContext)
        {
        }


    }
}