using AgendaDeTarefas;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaDeTarefas.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet <Task> Tarefa { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=DBAppSample;Integrated Security=True");
        }
    }
}
