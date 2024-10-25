using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiProvei.Models
{
    public class Veiculo
    {
        public Guid VeiculoId { get; set; }

        [Required]
        public string Modelo { get; set; }

        [Required]
        public string Marca { get; set; }

        public int Ano { get; set; }

        [Required]
        [StringLength(7)]
        public string Placa { get; set; }

        [ForeignKey("Patio")]
        public Guid PatioId { get; set; }
        public Patio Patio { get; set; }

        public bool Disponivel { get; set; } = true;
    }
}
