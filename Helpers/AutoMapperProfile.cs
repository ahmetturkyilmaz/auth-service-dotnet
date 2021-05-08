using auth_service_dotnet.Entities;
using auth_service_dotnet.Models.Users;
using AutoMapper;

namespace auth_service_dotnet.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<SignupRequest, User>();
            CreateMap<UpdateModel, User>();
        }
    }
}
