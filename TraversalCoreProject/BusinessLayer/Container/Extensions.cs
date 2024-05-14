using BusinessLayer.Abstract;
using BusinessLayer.Abstract.UowAbstract;
using BusinessLayer.Concrete;
using BusinessLayer.Concrete.UowConcrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.UnitofWork;
using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {

            // Comment ve diğer sayfalar gibi EF bağımlılığını ( new lemeyi ) kaldırıyoruz
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal, EfCommentDal>();

            //Destination
            services.AddScoped<IDestinationService, DestinationManager>();
            services.AddScoped<IDestinationDal, EfDestinationDal>();

            // AppUser
            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserDal>();

            //Rezervasyonlar
            services.AddScoped<IReservationService, ReservationManager>();
            services.AddScoped<IReservationDal, EfReservationDal>();

            // Rehberler
            services.AddScoped<IGuideService, GuideManager>();
            services.AddScoped<IGuideDal, EfGuideDal>();

            // Excel Service
            services.AddScoped<IExcelService, ExcelManager>();

            // Pdf Service
            services.AddScoped<IPdfService, PdfManager>();

            // Contact Us kısmı
            services.AddScoped<IContactUsService, ContactUsManager>();
            services.AddScoped<IContactUsDal, EfContactUsDal>();

            // Announcement kısmı
            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();

            //Unit of Work tanımlanması
            services.AddScoped<IAccountService,AccountManager>();
            services.AddScoped<IAccountDal,EfAccountDal>();

            services.AddScoped<IUowDal,UowDal>();
        }
        public static void CustomValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<AnnouncementAddDto>, AnnouncementValidator>();
        }
    }
}
