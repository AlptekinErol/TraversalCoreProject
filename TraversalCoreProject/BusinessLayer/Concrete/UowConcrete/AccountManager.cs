using BusinessLayer.Abstract.UowAbstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.UnitofWork;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.UowConcrete
{
    // burada neden IGenericUowden miras almadık 
    // çünkü account service kendine has method barındırabilir ve
    // ekstra olarak genericuow ile bağlantılı zaten , o methodlar geliyor  
    public class AccountManager : IAccountService      
    {
        // burada bunları kullanma sebebimiz OOP
        // yani diğer classlarda bulunan methodları kullanabilmek için
        // o classlardan nesne üretip methodlara ulaşabiliyoruz 17 ve 20. satır

        private readonly IAccountDal _accountDal; // _isimlendirmesi ekstra this ile tekrar çağırmamak için :) 27.satır
        private readonly IUowDal _uowDal;

        public AccountManager(IAccountDal accountDal, IUowDal uowDal)
        {
            _accountDal = accountDal;
            _uowDal = uowDal;
        }

        public void TCreate(Account entity)
        {
            _accountDal.Create(entity);
            _uowDal.Save();
        }

        public Account TGetAccById(int id)
        {
            return _accountDal.GetAccById(id);    
        }

        public void TMultipleUpdate(List<Account> entity)
        {
            _accountDal.MultiUpdate(entity);
            _uowDal.Save();
            // uowDal.Save = _context.SaveChanges() anlamına geliyor bu da UoW prensibidir zaten.
        }

        public void TUpdate(Account entity)
        {
            _accountDal.Update(entity);
            _uowDal.Save();
        }
    }
}
