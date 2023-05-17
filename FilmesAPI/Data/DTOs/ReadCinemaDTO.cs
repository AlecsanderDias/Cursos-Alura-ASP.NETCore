namespace FilmesAPI.Data.DTOs
{
    public class ReadCinemaDTO
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public ReadEnderecoDTO ReadEnderecoDto { get; set; }
    }
}
