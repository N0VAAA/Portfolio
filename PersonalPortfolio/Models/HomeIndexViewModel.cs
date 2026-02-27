namespace PersonalPortfolio.Models;

public sealed class HomeIndexViewModel
{
    public IReadOnlyList<ProjectCardViewModel> Projects { get; init; } = [];
    public IReadOnlyList<Skill> Skills { get; init; } = [];
}
