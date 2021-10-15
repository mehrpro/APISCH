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
        IEnumerable<Company> GetBuIds(IEnumerable<int> ids, bool trucking);
    }

    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(DbContext dbContext) : base(dbContext)
        {
        }


        public IEnumerable<Company> GetBuIds(IEnumerable<int> ids, bool trucking)
        {
            if (trucking)
            {
                return GetAll().Where(x => ids.Contains(x.ID));

            }
        }
    }