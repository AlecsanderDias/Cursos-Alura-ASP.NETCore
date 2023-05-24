using System.ComponentModel.DataAnnotations;

namespace UsuariosAPI.Data.Dtos;

public class CreateUsusarioDto
{
    [Required]
    public string UserName { get; set; }
    
    [Required]
    public DateTime DataNascimento { get; set; }
    
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required]
    [Compare("Password")]
    public string RePassword { get; set; }
}
