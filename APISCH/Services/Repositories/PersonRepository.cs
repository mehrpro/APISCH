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
        IList<Person> GetAllPersons();
    }

    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        private readonly DbContext _dbContext;

        public PersonRepository(DbContext dbContext) : base(dbContext)
        {
            this._dbContext = (this._dbContext ?? (ApplicationContext)_dbContext);
        }

        public IList<Person> GetAllPersons()
        {
            return GetAll().ToList();
        }
    }
}