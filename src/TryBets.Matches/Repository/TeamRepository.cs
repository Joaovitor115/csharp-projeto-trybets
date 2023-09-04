using TryBets.Matches.DTO;

namespace TryBets.Matches.Repository;

public class TeamRepository : ITeamRepository
{
    protected readonly ITryBetsContext _context;
    public TeamRepository(ITryBetsContext context)
    {
        _context = context;
    }

    public IEnumerable<TeamDTOResponse> Get()
    {

        var teams = _context.Teams.Select(x => new TeamDTOResponse
        {
            TeamId = x.TeamId,
            TeamName = x.TeamName
        }).ToList();

        return teams;
}
}