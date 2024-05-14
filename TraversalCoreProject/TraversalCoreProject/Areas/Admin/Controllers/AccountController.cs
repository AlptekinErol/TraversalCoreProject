using BusinessLayer.Abstract.UowAbstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.Areas.Admin.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(AccountViewModel model)
        {
            // Summary : Gönderici alıcı ve tutar bilgileri Entity değilde Model de tutuldu
            // ve bu sayede modelden gelen bu veriler entity üzerinde kullanılarak transaction gerçekleştirildi
            // amount burada entitylerde bulunan balance üzerinde değişiklik yapılması için tutuldu.
            // entity üzerinde tutar diye bir prop kullanamazdık zaten ( db de tutar ne alaka ?)
            // bunun yerine DB üzerinde Transaction diye bir table atıp da yapabilirdik fakat ListViewModel kullandık.

            var valueSender = _accountService.TGetAccById(model.SenderID); // Sender verilerine ulaştık
            var valueReceiver = _accountService.TGetAccById(model.ReceiverID); // Receiver verilerine ulaştık
            // senderId , receiverID ve Amount param from ListViewModel

            valueSender.Balance -= model.Amount;
            valueReceiver.Balance += model.Amount;
            // Balance güncellemesi yaptık

            List<Account> modifiedAccounts = new List<Account>()
            {
                valueSender,
                valueReceiver
            };
            _accountService.TMultipleUpdate(modifiedAccounts);
            return View(); 
        }
    }
}
