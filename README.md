```md
# Personal Portfolio — ASP.NET Core

Backend-focused portfolio built with **ASP.NET Core MVC**.

This project demonstrates clean structure, service abstraction, and secure HTTP practices using modern .NET.

---

## Tech Stack

- .NET 10
- ASP.NET Core MVC
- Blazor Server components (for reusable UI)
- Dependency Injection
- Bootstrap 5
- Font Awesome

---

## Architecture

The application follows a simple layered structure:

- **Controllers** → Orchestration only (no business logic)
- **Services** → Data access abstraction via interfaces
- **Models** → Domain entities and ViewModels
- **Middleware** → Security headers
- **Views / Components** → Presentation layer

Services return `IReadOnlyList<T>` to prevent external mutation.

A custom middleware adds HTTP security headers.

Health endpoint available at:
```

/health

```

---

## Run Locally

### Requirements

- .NET 10 SDK

Check version:

```

dotnet --version

```

### Start the app

```

dotnet restore
dotnet run --project PersonalPortfolio/PersonalPortfolio.csproj

```

Default URL:

```

[http://localhost:5206](http://localhost:5206)

```

---

## Purpose

This project showcases:

- REST-oriented backend structure
- Clean separation of concerns
- Secure HTTP configuration
- Maintainable ASP.NET Core architecture
```
