using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Filme
    {
        public int Id { get; internal set; }
        [Required(ErrorMessage = "O titulo do filme é obrigatório")]
        public string? Titulo { get; set; }
        [Required(ErrorMessage = "Genero do filme é obrigatório")]
        [MaxLength(50,ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")]
        public string? Genero { get; set; }
        [Required]
        [Range(70, 600, ErrorMessage = "A duração deve ser entre 70 e 600")]
        public int Duracao { get; set; }
       
    }
}
