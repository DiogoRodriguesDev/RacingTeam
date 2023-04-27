using AutoMapper;
using ClassLibrary_RacingTeam.Data;
using MediatR;
using RacingTeam_BlazorServer.Queries;
using ClassLibrary_RacingTeam.Models;

namespace RacingTeam_BlazorServer.Handlers
{

    public class GetPilotosHandler : IRequestHandler<GetPilotosQuery, List<Piloto>>
    {
        IDataContext _dataContext;

        IMapper _mapper;
        public GetPilotosHandler(IDataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }
        public Task<List<Piloto>> Handle(GetPilotosQuery request, CancellationToken cancellationToken)
        {
            var query = _dataContext.Pilotos.AsQueryable();

            if (!string.IsNullOrEmpty(request.Search))
            {
                query = query.Where(x => x.Name.Contains(request.Search) || x.Description.Contains(request.Search));
            }

            var handMapped = query.Select(x => new Piloto
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                IsDeleted = x.IsDeleted,
                Category = x.Category,
                Price = x.Price
            }).ToList();

            var autoMapped = _mapper.Map<List<Piloto>>(query);

            return Task.FromResult(autoMapped);
        }
    }
}
}
