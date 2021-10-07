using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud.Models
{
    public class Pessoa
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string SobreNome { get; set; }
        public string CPF { get; set; }

        public int Idade { get; set; }
        public string Telefone { get; set; }


    }
}
