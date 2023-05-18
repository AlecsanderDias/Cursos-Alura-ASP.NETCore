using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTOs;

public class ReadFilmeDTO
{
    public string Titulo { get; set; }
    public string Genero { get; set; }
    public int Duracao { get; set; }
    public DateTime HorarioDaConsulta { get; set; } = DateTime.Now;
    public ICollection<ReadSessaoDTO> Sessoes { get; set; }
}
