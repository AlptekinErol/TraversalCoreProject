using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract.UowAbstract
{
    public interface IGenericUowService<T> where T : class
    {
        void TCreate(T entity);
        void TUpdate(T entity);
        void TMultipleUpdate(List<T> entity);
        T TGetAccById(int id);
    }
}
