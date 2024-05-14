using DocumentFormat.OpenXml.Drawing.Charts;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TraversalCoreProject.Areas.Admin.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Role")]

    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public RoleController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        [Route("Index")]
        public IActionResult Index()
        {
            var values = _roleManager.Roles.ToList(); // _roleManager => is object from RoleManager class (identity package)
                                                      // .Roles => is Entity that we re using for Roles
                                                      // .ToList() => is the function that we can use it for listing the entity
            return View(values);
        }

        [HttpGet]
        [Route("CreateNewRole")]

        public IActionResult CreateNewRole()
        {
            return View();
        }
        [HttpPost]
        [Route("CreateNewRole")]
        public async Task<IActionResult> CreateNewRole(CreateRoleViewModel createRoleViewModel)
        {
            AppRole role = new AppRole()
            {
                Name = createRoleViewModel.RoleName
            };
            var result = await _roleManager.CreateAsync(role);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }

        }
        [Route("DeleteRole/{id}")]
        public async Task<IActionResult> DeleteRole(int id)
        {
            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            await _roleManager.DeleteAsync(values);
            return RedirectToAction("Index");

        }
        [Route("UpdateRole/{id}")]
        [HttpGet]
        public IActionResult UpdateRole(int id)
        {
            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            UpdateRoleViewModel updateRoleViewModel = new UpdateRoleViewModel
            {
                RoleID = values.Id,
                RoleName = values.Name,
            };
            return View(updateRoleViewModel);
        }

        [Route("UpdateRole/{id}")]
        [HttpPost]
        public async Task<IActionResult> UpdateRole(UpdateRoleViewModel updateRoleViewModel)
        {
            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == updateRoleViewModel.RoleID);
            values.Name = updateRoleViewModel.RoleName;
            await _roleManager.UpdateAsync(values);
            return RedirectToAction("Index");
        }

        [Route("UserList")]
        public IActionResult UserList()
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }

        [Route("AssignRole/{id}")]

        public async Task<IActionResult> AssignRole(int id)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id); // önce ilgili kullanıcı verisi geliyor
            TempData["UserId"] = user.Id;                                  // geçici id tutuyoruz
            var role = _roleManager.Roles.ToList();                        // ardından roller geliyor
            var userRoles = await _userManager.GetRolesAsync(user);        // identity kütüphanesine özel method => gönderilen parametrenin rolleri getiriliyor
            List<RoleAssignViewModel> roleAssignViewModels = new List<RoleAssignViewModel>();
            foreach (var item in role) // role 103. satırda çekiliyor zaten
            {
                RoleAssignViewModel model = new RoleAssignViewModel();
                model.RoleId = item.Id;
                model.RoleName = item.Name;
                model.RoleExist = userRoles.Contains(item.Name);  // contains => returns true yada false döner 
                roleAssignViewModels.Add(model);
            }
            return View(roleAssignViewModels);
            // Summary : 105. satır RoleAssign türünde bir list tanımlandı ardından bu liste
            // 106. satır foreach ile içerisinde bu class türünde bir nesne tarafından içerisi dolduruldu
        }

        [HttpPost]
        [Route("AssignRole/{id}")]
        public async Task<IActionResult> AssignRole(List<RoleAssignViewModel> model)
        {
            var userid = (int)TempData["UserId"];  // başına int koyduk çünkü userid bir obje integer değil
            var user = _userManager.Users.FirstOrDefault(x=>x.Id == userid);
            foreach (var item in model)
            {
                if(item.RoleExist)
                {
                    await _userManager.AddToRoleAsync(user, item.RoleName);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, item.RoleName);
                }
            }
            return RedirectToAction("UserList");
        }
    }
}
