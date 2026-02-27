namespace PersonalPortfolio.Models;

public static class ProjectCardMapper
{
    private static readonly Dictionary<int, (string AccentClass, string TypeLabel)> _map = new()
    {
        { 1, ("accent-auth",      "Auth / Security") },
        { 2, ("accent-books",     "Minimal API")     },
        { 3, ("accent-bitly",     "Minimal API")     },
        { 4, ("accent-portfolio", "Web App")         },
    };

    public static ProjectCardViewModel ToViewModel(Project project)
    {
        var (accent, label) = _map.TryGetValue(project.Id, out var entry)
            ? entry
            : ("accent-default", "Project");

        return new ProjectCardViewModel(project, accent, label);
    }

    public static IReadOnlyList<ProjectCardViewModel> ToViewModels(
        IEnumerable<Project> projects) =>
        projects.Select(ToViewModel).ToList().AsReadOnly();
}
