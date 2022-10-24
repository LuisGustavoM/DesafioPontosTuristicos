using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Application.DTOs
{
    public class PontosTuristicosDTO
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [MinLength(3)]
        [MaxLength(100)]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [MinLength(1)]
        [MaxLength(100)]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [MinLength(1)]
        [MaxLength(100)]
        [DisplayName("Referência")]
        public string Referencia { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [DisplayName("Cidade")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [DisplayName("Estado")]
        public string Estado { get; set; }
        public DateTime DataHoraCadastro { get; set; }
    }
}
