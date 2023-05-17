using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTOs;

public class UpdateCinemaDTO
{
    [Required(ErrorMessage = "O campo de nome é obrigatório!")]
    public String Nome { get; set; }
}
