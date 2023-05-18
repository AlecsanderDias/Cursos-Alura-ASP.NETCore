namespace FilmesAPI.Data.DTOs
{
    public class ReadCinemaDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ReadEnderecoDTO ReadEnderecoDto { get; set; }
        public ICollection<ReadSessaoDTO> Sessoes { get; set; }
    }
}
