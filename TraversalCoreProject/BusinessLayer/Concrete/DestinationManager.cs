using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DestinationManager : IDestinationService
    {
        IDestinationDal _destinationdal;
        public DestinationManager(IDestinationDal destinationdal)
        {
            _destinationdal = destinationdal;
        }

        public void TAdd(Destination entity)
        {
            _destinationdal.Create(entity);  
        }

        public void TDelete(Destination entity)
        {
            _destinationdal.Delete(entity);
        }

        public Destination TGetById(int id)
        {
            return _destinationdal.GetListId(id);
        }

        public Destination TGetDestinationWithGuide(int id)
        {
            return _destinationdal.GetDestinationWithGuide(id);
        }

        public List<Destination> TGetLast4Destinations()
        {
            return _destinationdal.GetLast4Destinations();
        }

        public List<Destination> TGetList()
        {
            var values = _destinationdal.GetList();
            return (values);
        }

        public void TUpdate(Destination entity)
        {
            _destinationdal.Update(entity);
        }
    }
}
