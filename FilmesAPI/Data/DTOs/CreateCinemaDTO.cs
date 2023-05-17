﻿using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTOs;

public class CreateCinemaDTO
{
    [Required(ErrorMessage = "O campo de nome é obrigatório!")]
    public String Nome { get; set; }
    public int EnderecoId { get; set; }
}