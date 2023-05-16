using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTOs;

public class CreateFilmeDTO
{
    [Required(ErrorMessage = "O título do filme é obrigatório!")]
    [MaxLength(50, ErrorMessage = "O título do filme deve ter no máximo até 50 caracteres!")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O gênero do filme é obrigatório!")]
    [StringLength(50, ErrorMessage = "O gênerodo filme deve ter no máximo até 20 caracteres!")]
    public string Genero { get; set; }

    [Range(70, 600, ErrorMessage = "A duração do filme deve ser entre 70 e 600 minutos!")]
    public int Duracao { get; set; }
}
