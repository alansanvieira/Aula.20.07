using Microsoft.EntityFrameworkCore;
using PoCWebAPI.Models;

namespace PoCWebAPI.Models
{
    public class EscolaContext: DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder Modelagem)
        {
            Modelagem.Entity<Aluno>(Aluno =>
            {
                Aluno.HasKey(Coluna => Coluna.Id);
            });

            Modelagem.Entity<Curso>(Curso =>
            {
                Curso.HasKey(Coluna => Coluna.Id);

                Curso.HasMany(Coluna => Coluna.Alunos);
            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder Configuracao)
        {
            Configuracao.UseInMemoryDatabase("Escola");
        }

        public DbSet<PoCWebAPI.Models.Curso>? Curso { get; set; }
    }
}
