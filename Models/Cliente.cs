using System.ComponentModel.DataAnnotations;

namespace ApiProvei.Models
{
    public class Cliente
    {
        public Guid ClienteId { get; set; }


        [Display(Name = "Nome do Cliente")]
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo Nome deve ter no máximo 100 caracteres")]
        public string ClienteNome { get; set; }


        [Required(ErrorMessage = "O Campo CPF é obrigatório")]
        [StringLength(14, ErrorMessage = "O campo CPF deve ter no máximo 14 caracteres")]
        public string CPF { get; set; }




        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O Campo E-mail é obrigatório")]
        [StringLength(150, ErrorMessage = "O campo E-mail deve ter no máximo 150 caracteres")]
        public string Email { get; set; }



        [StringLength(15, ErrorMessage = "O campo Celular deve ter no máximo 15 caracteres")]
        public string? Celular { get; set; }

    }
}
