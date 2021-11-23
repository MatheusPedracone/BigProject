using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyApp.Api.Dtos
{
    public class EventoDto
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [MinLength(4), MaxLength(50)]
        public string Tema { get; set; }
        [Display(Name = "Qtd Pessoas.")]
        [Range(1, 5000, ErrorMessage = " {0} não pode ser menor que 1 e maior que 5000.")]
        public int QtdPessoas { get; set; }
        [RegularExpression(@".*\.(gif|jpe?g|bmp|png)$",
                           ErrorMessage = "Não é uma imagem válida. (gif, jpg, jpeg, bmp ou png)")]
        public string ImagemURL { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Phone(ErrorMessage = "O campo {0} deve ser válido.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [EmailAddress(ErrorMessage = "É necessario ser um {0} válido.")]
        public string Email { get; set; }
        public IEnumerable<LoteDto> Lotes { get; set; }
        public IEnumerable<RedeSocialDto> RedesSociais { get; set; }
        public IEnumerable<PalestranteDto> PalestrantesEventos { get; set; }
    }
}