using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfAccountDal:GenericUowRepository<Account>,IAccountDal
    {
        public EfAccountDal(Context context) : base (context)  // base kullanma sebebimiz Üst sınıf olan
                                                               // GenericUowRepository de bulunan contexte ulaşabilmek. (örn.. base ve this kullanımı)
        {
                
        }
    }
}
