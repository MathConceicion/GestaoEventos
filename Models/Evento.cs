using System.ComponentModel.DataAnnotations;

namespace GestaoEventos.Models
{
    public class Evento
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do evento é obrigatório")]
        [StringLength(100)]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "Selecione uma Data")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Selecione uma Categoria")]
        // Relacionamento com Categoria
        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }

        [Required(ErrorMessage = "Selecione um Local")]
        public int LocalId { get; set; }
        public Local? Local { get; set; }

    }
}
