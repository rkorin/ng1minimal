using BAL.Interfaces;
using DAL.Interfaces;
using Microsoft.Practices.Unity;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Facades
{
    public class PersonFacade : ICRUDFacade<Person>
    {
        [Dependency]
        public IRepository<Person> repository { get; set; }
        

        public void delete(int id)
        {
            repository.delete(id);
        }

        public IEnumerable<Person> get()
        {
            return repository.get();
        }

        public Person get(int id)
        {
            return repository.get(id);
        }

        public void save(Person entity)
        {
            repository.save(entity);
        }
    }
}
