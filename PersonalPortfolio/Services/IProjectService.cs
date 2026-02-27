using PersonalPortfolio.Models;

namespace PersonalPortfolio.Services;

public interface IProjectService
{
    Task<IReadOnlyList<Project>> GetAllAsync(CancellationToken ct = default);
    Task<IReadOnlyList<Project>> GetFeaturedAsync(CancellationToken ct = default);
}
