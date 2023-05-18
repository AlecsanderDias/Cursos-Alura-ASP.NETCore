using AutoMapper;
using FilmesAPI.Data.DTOs;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles;

public class CinemaProfile : Profile
{
    public CinemaProfile()
    {
        CreateMap<CreateCinemaDTO, Cinema>();
        CreateMap<UpdateCinemaDTO, Cinema>();
        CreateMap<Cinema, ReadCinemaDTO>()
            .ForMember(cinemaDTO=> cinemaDTO.ReadEnderecoDto, opt => opt.MapFrom(cinema => cinema.Endereco))
            .ForMember(cinemaDTO => cinemaDTO.Sessoes, opt => opt.MapFrom(cinema => cinema.Sessoes));
    }
}
