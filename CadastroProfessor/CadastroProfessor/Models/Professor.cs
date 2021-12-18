using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroProfessor.Models
{
    public class Professor
    {
        [Key]
        public int Profid {get; set;}
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Disciplina { get; set; }

    }
}
