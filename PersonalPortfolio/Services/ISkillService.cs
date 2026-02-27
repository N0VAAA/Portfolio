using PersonalPortfolio.Models;
using PersonalPortfolio.Models.Enums;

namespace PersonalPortfolio.Services;

public interface ISkillService
{
    Task<IReadOnlyList<Skill>> GetAllAsync(CancellationToken ct = default);
    Task<IReadOnlyList<Skill>> GetByCategoryAsync(SkillCategory category, CancellationToken ct = default);
}
