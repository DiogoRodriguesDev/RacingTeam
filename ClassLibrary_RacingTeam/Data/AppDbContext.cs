using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_RacingTeam.Models;

namespace ClassLibrary_RacingTeam.Data
{
    public class AppDbContext : DbContext, IDataContext
    {
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Circuito> Circuitos { get; set; }
        public DbSet<ClassificacaoGeral> Classificacoes { get; set; }
        public DbSet<Competicao> Competicoes { get; set; }
        public DbSet<Corrida> Corridas { get; set; }
        public DbSet<Equipa> Equipas { get; set; }
        public DbSet<Piloto> Pilotos { get; set; }
        public DbSet<Resultado> Resultados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Data Source=DIO-PC\MSSQL_SERVER_DIO;Initial Catalog=AppDataBase; Trusted_Connection=True; TrustServerCertificate=True;");
        }
    }
}
