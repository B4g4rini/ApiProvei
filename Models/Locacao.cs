using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiProvei.Models
{
    public class Locacao
    {
       
        public Guid LocacaoId { get; set; }

        [ForeignKey("Veiculo")]
        public Guid VeiculoId { get; set; }
        public Veiculo Veiculo { get; set; }

        [ForeignKey("Cliente")]
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        [Required]
        public string Status { get; set; }
    }
}
