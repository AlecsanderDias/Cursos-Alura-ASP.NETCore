using AutoMapper;
using UsuariosAPI.Data.Dtos;
using UsuariosAPI.Models;

namespace UsuariosAPI.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<CreateUsusarioDto, Usuario>();
    }
}
