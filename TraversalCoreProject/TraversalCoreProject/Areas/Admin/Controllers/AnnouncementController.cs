using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.Areas.Admin.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
   
    [Area("Admin")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;
        private readonly IMapper _mapper;

        public AnnouncementController(IAnnouncementService announcementService, IMapper mapper)
        {
            _announcementService = announcementService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            #region
            //List<Announcement> announcements = _announcementService.TGetList(); // tüm entity getlist ile çekildi
            //List<AnnouncementListViewModel> modelList = new List<AnnouncementListViewModel>(); // türü ancListView model olan list tanımlandı
            // foreach (var item in announcements)
            // {
            //     AnnouncementListViewModel announcementListViewModel = new AnnouncementListViewModel(); // oluşturduğumuz ALV classından (viewmodel)

            //     announcementListViewModel.ID = item.AnnouncementID;
            //     announcementListViewModel.Title = item.Title;                                             // obje türetip değerlere ulaştık
            //     announcementListViewModel.Content = item.Content;

            //     modelList.Add(announcementListViewModel);                                                // 21. satırda oluşturduğumuz asıl
            //                                                                                              // hedef olan kısıtlı listeye aktarma yaptık
            // }
            #endregion
            //22-34 arası ListViewModel kullanımına örnek
            var values = _mapper.Map<List<AnnouncementListDto>>(_announcementService.TGetList()); // Model yerine oluşturduğumuz
                                                                                                  // DTO üzerinden veri çekiyoruz

            return View(values);
        }
        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAnnouncement(AnnouncementAddDto model)
        {
            if (ModelState.IsValid)
            {
                _announcementService.TAdd(new Announcement()
                {
                    Content = model.Content,
                    Title = model.Title,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
            }
            return RedirectToAction("Index");
        }
        public IActionResult DeleteAnnouncement(int id)
        {
            var values = _announcementService.TGetById(id);
            _announcementService.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateAnnouncement(int id)
        {
            var values = _mapper.Map<AnnouncementUpdateDto>(_announcementService.TGetById(id)); //maplerken target sonra source yazılır                                                                                     // Source ise serviste bulunan method sayesinde veri alır
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateAnnouncement(AnnouncementUpdateDto model)
        {
            if (ModelState.IsValid)
            {
                _announcementService.TUpdate(new Announcement
                {
                    AnnouncementID = model.AnnouncementID,
                    Title = model.Title,
                    Content = model.Content,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
