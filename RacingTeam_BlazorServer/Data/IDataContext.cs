using ClassLibrary_RacingTeam.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary_RacingTeam.Data
{
    public interface IDataContext
    {
        DbSet<Carro> Carros { get; set; }
        DbSet<Circuito> Circuitos { get; set; }
        DbSet<ClassificacaoGeral> Classificacoes { get; set; }
        DbSet<Competicao> Competicoes { get; set; }
        DbSet<Corrida> Corridas { get; set; }
        DbSet<Equipa> Equipas { get; set; }
        DbSet<Piloto> Pilotos { get; set; }
        DbSet<Resultado> Resultados { get; set; }
        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellation = default);
    }
}
