using System.ComponentModel.DataAnnotations;

namespace ApiProvei.Models
{
    public class Patio
    {
        public Guid PatioId { get; set; }

        [Required]
        public string Nome { get; set; }

        public string Endereco { get; set; }
    }
}
