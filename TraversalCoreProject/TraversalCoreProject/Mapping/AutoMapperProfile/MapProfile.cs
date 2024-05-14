using AutoMapper;
using DTOLayer.DTOs.AnnouncementDTOs;
using DTOLayer.DTOs.AppUserDTOs;
using DTOLayer.DTOs.ContactDTOs;
using EntityLayer.Concrete;

namespace TraversalCoreProject.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            // AnnouncementAdd Mapping ( Dto is mapped with entity)
            CreateMap<AnnouncementAddDto, Announcement>().ReverseMap();   // reverse mapped with ReverseMap()

            // AppUserRegister mapping ( dto is mapped with AppUserRegister Entity)
            CreateMap<AppUserRegisterDTO, AppUser>().ReverseMap();        // reverse mapped with ReverseMap()

            // AppUserLogin mapping ( dto is mapped with AppUserLogin Entity)
            CreateMap<AppUserLoginDTO, AppUser>().ReverseMap();           // reverse mapped with ReverseMap()

            // AnnouncementList mapping ( dto is mapped with entity)
            CreateMap<AnnouncementListDto, Announcement>().ReverseMap();  // reverse mapped with ReverseMap()

            // AnnouncementUpdate mapping ( dto is mapped with entity)
            CreateMap<AnnouncementUpdateDto, Announcement>().ReverseMap();  // reverse mapped with ReverseMap()
                                                                            // no longer need to write the same code reverse

            CreateMap<SendMessaageDTO,ContactUs>().ReverseMap(); // reverse mapped with method.. ^^^^
        }
    }
}
