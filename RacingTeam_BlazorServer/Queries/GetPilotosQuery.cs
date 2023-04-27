using ClassLibrary_RacingTeam.Models;
using MediatR;

namespace RacingTeam_BlazorServer.Queries
{

    public record GetPilotosQuery : IRequest<List<Piloto>>
    {
        public string? Search { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
