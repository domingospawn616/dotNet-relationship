using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Matricula
    {
        public int Id { get; set; }
        public Estudante Estudante { get; set; }
        public Turma Turma { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}
