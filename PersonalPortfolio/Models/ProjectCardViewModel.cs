namespace PersonalPortfolio.Models;

public sealed record ProjectCardViewModel(
    Project Project,
    string AccentClass,
    string TypeLabel
);
