using PersonalPortfolio.Models;
using PersonalPortfolio.Models.Enums;

namespace PersonalPortfolio.Services;

public sealed class SkillService : ISkillService
{
    private readonly IReadOnlyList<Skill> _all;
    private readonly ILookup<SkillCategory, Skill> _byCategory;

    public SkillService()
    {
        _all = new List<Skill>
        {
            new() { Name = "C#",                 Category = SkillCategory.Backend,  ProficiencyLevel = 5, IconClass = "fab fa-microsoft"  },
            new() { Name = "ASP.NET Core",       Category = SkillCategory.Backend,  ProficiencyLevel = 4, IconClass = "fas fa-server"     },
            new() { Name = "REST / Minimal API", Category = SkillCategory.Backend,  ProficiencyLevel = 4, IconClass = "fas fa-code"       },
            new() { Name = "JWT / Auth",         Category = SkillCategory.Backend,  ProficiencyLevel = 4, IconClass = "fas fa-shield-alt" },
            new() { Name = "Entity Framework",   Category = SkillCategory.Database, ProficiencyLevel = 4, IconClass = "fas fa-database"   },
            new() { Name = "PostgreSQL",         Category = SkillCategory.Database, ProficiencyLevel = 3, IconClass = "fas fa-database"   },
            new() { Name = "SQL",                Category = SkillCategory.Database, ProficiencyLevel = 4, IconClass = "fas fa-database"   },
            new() { Name = "xUnit",              Category = SkillCategory.Testing,  ProficiencyLevel = 4, IconClass = "fas fa-vial"       },
            new() { Name = "Git",                Category = SkillCategory.Tools,    ProficiencyLevel = 4, IconClass = "fab fa-git-alt"    },
            new() { Name = "Blazor",             Category = SkillCategory.Frontend, ProficiencyLevel = 3, IconClass = "fas fa-bolt"       },
        }.AsReadOnly();

        _byCategory = _all.ToLookup(s => s.Category);
    }

    public Task<IReadOnlyList<Skill>> GetAllAsync(CancellationToken ct = default)
        => Task.FromResult(_all);

    public Task<IReadOnlyList<Skill>> GetByCategoryAsync(
        SkillCategory category, CancellationToken ct = default) =>
        Task.FromResult<IReadOnlyList<Skill>>(
            _byCategory[category].ToList().AsReadOnly());
}
