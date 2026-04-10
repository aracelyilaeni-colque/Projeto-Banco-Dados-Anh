

using System.ComponentModel.DataAnnotations;

namespace Segundo_App_BancoDados.Models
{
    public class Usuario
    {
        [Display(Name ="Código")]
        public int? idUsu { get; set; }

        [Display(Name ="Nome Completo")]
        [Required(ErrorMessage ="Campo nome é obrigatorio")]
        public string NomeUsu { get; init; }

        [Display(Name = "Cargo")]
        [Required(ErrorMessage = "Campo Cargo é obrigatorio")]
        public string Cargo { get; init; }

        [Display(Name ="Data Nascimento")]
        [Required(ErrorMessage = " Data Nascimento é obrigatorio")]
        [DataType(DataType.DateTime)]
        public DateTime DataNasc { get; init; }


        

    } 
        

}

