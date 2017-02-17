using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Interfaces
{
    public interface ICRUDFacade<T> where T : class
    {
        T get(int id);
        IEnumerable<T> get();
        void save(T entity);
        void delete(int id);
    }
}
