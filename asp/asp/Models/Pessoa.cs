using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace crud.Models
{
    public class Pessoa
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome deve ser preenchido")]
        public string Name { get; set; }


        [Required(ErrorMessage = "O campo SobreNome deve ser preenchido")]
        public string SobreNome { get; set; }

        [MinLength(10,ErrorMessage = "O CPF precisa ter no minimo 10 caracteres")]
        [Required(ErrorMessage = "O campo CPF deve ser preenchido")]
        public string CPF { get; set; }

        [Required( ErrorMessage = "O campo Idade deve ser preenchido")]
        public int Idade { get; set; }


        [Required(ErrorMessage = "O Telefone precisa ter no minimo 10 caracteres")]
        [MinLength(8, ErrorMessage = "O campo Telefone deve ser preenchido")]
        public string Telefone { get; set; }


    }
}
