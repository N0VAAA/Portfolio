# Personal Portfolio — ASP.NET Core

Backend-focused portfolio built with **ASP.NET Core MVC**.

This project demonstrates clean architecture principles, service abstraction, and secure HTTP configuration using modern .NET practices.

---

## Overview

This portfolio is structured as a small production-style ASP.NET Core application rather than a static website.

It applies:

- Clear separation of concerns
- Dependency Injection
- Layered architecture
- HTTP security middleware
- Health monitoring

The goal is to showcase backend engineering practices in a simple, maintainable structure.

---

## Tech Stack

- .NET 10
- ASP.NET Core MVC
- Blazor Server Components
- Dependency Injection
- Bootstrap 5
- Font Awesome

---

## Architecture

The project follows a layered structure:

```

Presentation
├── Views (Razor)
├── Blazor Components
└── Static assets (wwwroot)

Application
├── Controllers
└── ViewModels

Services
├── IProjectService
└── ISkillService

Domain
├── Project
├── Skill
└── Supporting models

Infrastructure
└── Middleware (Security Headers)

```

### Key Design Choices

- Controllers contain **no business logic**
- Services are injected via **interfaces**
- Collections are exposed as `IReadOnlyList<T>`
- HTTP security headers handled through dedicated middleware
- Health endpoint available at:

```

/health

```

---

## Run Locally

### Requirements

- .NET 10 SDK

Check your version:

```bash
dotnet --version
```

### Start the application

```bash
dotnet restore
dotnet run --project PersonalPortfolio/PersonalPortfolio.csproj
```

## What This Project Demonstrates

- REST-oriented backend structure
- Clean separation between layers
- Secure HTTP configuration
- Maintainable and extensible architecture
- Production-style ASP.NET Core setup

---

## Future Improvements

- Convert services to async (`Task<IReadOnlyList<T>>`)
- Add unit tests (xUnit + Moq)
- Introduce a database layer (EF Core + PostgreSQL)
- Add structured logging (Serilog)
- Implement Content Security Policy (CSP)
