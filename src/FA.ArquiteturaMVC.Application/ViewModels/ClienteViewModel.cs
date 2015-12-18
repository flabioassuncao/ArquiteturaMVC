using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace FA.ArquiteturaMVC.Application.ViewModels
{
    public class ClienteViewModel
    {
        public ClienteViewModel()
        {
            ClienteID = Guid.NewGuid();
        }

        [Key]
        public Guid ClienteID { get; set; }
        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(150, ErrorMessage ="Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Preencha o nome E-mail")]
        [MaxLength(100, ErrorMessage ="Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage ="Preencha um email válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Preencha o campo CPF")]
        [MaxLength(11, ErrorMessage ="Máximo {0} caractere")]
        [DisplayName("CPF")]
        public string CPF { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString ="{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage ="Data em formato inválido")]
        public DateTime DataNascimento { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        [ScaffoldColumn(false)]
        public bool Ativo { get; set; }
    }
}
