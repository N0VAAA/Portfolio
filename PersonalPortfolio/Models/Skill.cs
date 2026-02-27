using PersonalPortfolio.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace PersonalPortfolio.Models;

public sealed class Skill
{
    public string Name { get; init; } = string.Empty;
    public SkillCategory Category { get; init; }
    [Range(1, 5)]
    public int ProficiencyLevel { get; init; }
    public string IconClass { get; init; } = string.Empty;
}
