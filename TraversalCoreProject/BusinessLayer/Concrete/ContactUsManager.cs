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
    public class ContactUsManager : IContactUsService
    {
        IContactUsDal _contactUs;

        public ContactUsManager(IContactUsDal contactUs)
        {
            _contactUs = contactUs;
        }
        public void TAdd(ContactUs entity)
        {
            _contactUs.Create(entity);
        }

        public void TContactUsStatusChangeToFalse(int id)
        {
            throw new NotImplementedException();
        }

        public void TDelete(ContactUs entity)
        {
            _contactUs.Delete(entity);
        }

        public ContactUs TGetById(int id)
        {
            var values = _contactUs.GetListId(id);
            return values;
        }

        public List<ContactUs> TGetList()
        {
            return _contactUs.GetList();
        }

        public List<ContactUs> TGetListContactUsByFalse()
        {
            return _contactUs.GetListContactUsByFalse();
        }

        public List<ContactUs> TGetListContactUsByTrue()
        {
           return _contactUs.GetListContactUsByTrue();
        }

        public void TUpdate(ContactUs entity)
        {
            _contactUs.Update(entity);
        }
    }
}
