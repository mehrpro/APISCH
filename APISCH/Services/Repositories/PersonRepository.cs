using System.Collections;
using System.Collections.Generic;
using System.Linq;
using APISCH.Entities;
using APISCH.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace APISCH.Services.Repositories
{
    public interface IPersonRepository : IRepository<Person>
    {
        void CreatePersonForCompany(int companyId, Person model);
    }

    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        private readonly DbContext _dbContext;

        public PersonRepository(DbContext dbContext) : base(dbContext)
        {
            this._dbContext = (this._dbContext ?? (ApplicationContext)_dbContext);
        }


        public void CreatePersonForCompany(int companyId, Person model)
        {
            model.CompanyID_FK = companyId;
            Insert(model);
        }
    }
}