using PersonalPortfolio.Models;

namespace PersonalPortfolio.Services;

public sealed class ProjectService : IProjectService
{
    private readonly IReadOnlyList<Project> _all;
    private readonly IReadOnlyList<Project> _featured;

    public ProjectService()
    {
        _all = new List<Project>
        {
            new()
            {
                Id          = 1,
                Title       = "Authentication API",
                Description = """
                    Authentication API with JWT, rotating refresh tokens, Admin/User roles,
                    and password hashing via ASP.NET Core Identity's PasswordHasher<T>.
                    Interactive docs via Scalar.
                    """,
                Highlights =
                [
                    new() { IconClass = "fas fa-shield-alt",  Text = "Access token (HMAC-SHA512) + refresh token with expiry stored in DB" },
                    new() { IconClass = "fas fa-users-cog",   Text = "Roles embedded in claims — [Authorize(Roles = \"Admin\")] endpoint" },
                    new() { IconClass = "fas fa-code-branch", Text = "IAuthService interface / implementation injected via DI" },
                    new() { IconClass = "fas fa-file-alt",    Text = "Interactive API docs with Scalar (OpenAPI)" },
                ],
                Technologies  = ["C#", "ASP.NET Core", "JWT", "EF Core", "SQLite", "Scalar"],
                GitHubUrl     = "https://github.com/N0VAAA/JWTAuth",
                IsFeatured    = true,
                CompletedDate = new DateOnly(2026, 1, 15)
            },
            new()
            {
                Id          = 2,
                Title       = "BookStore API",
                Description = """
                    Full CRUD REST API using Minimal API — books and genres with FK relation,
                    typed DTOs, DataAnnotations validation, and AsNoTracking() on list queries.
                    """,
                Highlights =
                [
                    new() { IconClass = "fas fa-sitemap",      Text = "Endpoints organized as extension methods (MapBooksEndPoints)" },
                    new() { IconClass = "fas fa-right-left",   Text = "Separate DTOs: BookSummaryDto / BookDetailsDto" },
                    new() { IconClass = "fas fa-check-circle", Text = "Validation on record DTOs — StringLength, Range" },
                    new() { IconClass = "fas fa-database",     Text = "Versioned EF Core migrations, auto-applied on startup" },
                ],
                Technologies  = ["C#", "ASP.NET Core", "Minimal API", "EF Core", "SQLite"],
                GitHubUrl     = "https://github.com/N0VAAA/BookStoreAPI",
                IsFeatured    = true,
                CompletedDate = new DateOnly(2025, 12, 10)
            },
            new()
            {
                Id          = 3,
                Title       = "URL Shortener",
                Description = """
                    URL shortening service with unique short code generation, URL validation
                    via Uri.TryCreate, HTTP redirect, and unique index on Code via Fluent API.
                    """,
                Highlights =
                [
                    new() { IconClass = "fas fa-link",     Text = "7-char code generation with collision-check loop against DB" },
                    new() { IconClass = "fas fa-shuffle",  Text = "HTTP redirect via Results.Redirect()" },
                    new() { IconClass = "fas fa-check",    Text = "URL validation with Uri.TryCreate before processing" },
                    new() { IconClass = "fas fa-database", Text = "Unique index on Code configured via Fluent API" },
                ],
                Technologies  = ["C#", "ASP.NET Core", "Minimal API", "EF Core", "Swagger"],
                GitHubUrl     = "https://github.com/N0VAAA/URLShortener",
                IsFeatured    = true,
                CompletedDate = new DateOnly(2026, 1, 20)
            },
            new()
            {
                Id          = 4,
                Title       = "Portfolio",
                Description = """
                    This site — ASP.NET Core MVC with Blazor Server components,
                    built following the official Microsoft learning path.
                    """,
                Highlights    = [],
                Technologies  = ["C#", "ASP.NET Core MVC", "Blazor Server", "Bootstrap"],
                GitHubUrl     = "https://github.com/N0VAAA/Portfolio",
                IsFeatured    = false,
                CompletedDate = new DateOnly(2026, 2, 1)
            }
        }.AsReadOnly();

        _featured = _all.Where(p => p.IsFeatured).ToList().AsReadOnly();
    }

    public Task<IReadOnlyList<Project>> GetAllAsync(CancellationToken ct = default)
        => Task.FromResult(_all);

    public Task<IReadOnlyList<Project>> GetFeaturedAsync(CancellationToken ct = default)
        => Task.FromResult(_featured);
}