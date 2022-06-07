using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DataDbContext: DbContext
    {
        DbSet<Estudante> Estudantes { get; set; }
        DbSet<Turma> Turmas { get; set; }

        DbSet<Disciplina> Disciplinas { get; set; }
        DbSet<Matricula> Matriculas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=D:\\SourceCode\\dotNet\\aspNetCore\\relationship\\dataBase\\db01.db");
       
    }
}
