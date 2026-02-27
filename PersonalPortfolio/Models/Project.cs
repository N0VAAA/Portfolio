namespace PersonalPortfolio.Models;

public sealed class Project
{
    public int Id { get; init; }
    public string Title { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public List<TechHighlight> Highlights { get; init; } = [];
    public List<string> Technologies { get; init; } = [];
    public string GitHubUrl { get; init; } = string.Empty;
    public string? LiveUrl { get; init; }
    public string? ImageUrl { get; init; }
    public DateOnly CompletedDate { get; init; }
    public bool IsFeatured { get; init; }
}
