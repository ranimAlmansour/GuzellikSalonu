using AutoMapper;
using GuzellikSalonu.Entities;
using GuzellikSalonu.Models;

namespace GuzellikSalonu
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig() 
        {
            CreateMap<User, UserModel>().ReverseMap();
            //CreateMap<User, CreateUserModel>().ReverseMap();
            //CreateMap<User, EditUserModel>().ReverseMap();
        }
    }
}
