using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Turma
    {
        public int Id { get; set; } 
        public string Descricao { get; set; }

        public List<Estudante> Alunos { get; set; }
    }
}
