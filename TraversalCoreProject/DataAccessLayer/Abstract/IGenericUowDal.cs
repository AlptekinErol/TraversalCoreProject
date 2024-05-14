using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericUowDal<T> where T : class
    {
        void Create(T entity);
        void Update(T entity);
        void MultiUpdate(List<T> t); // aynı anda birden fazla kaydı güncellemek için 

        T GetAccById(int id);
    }
}
