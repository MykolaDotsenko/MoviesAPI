# MoviesAPI

An ASP.NET Core movie REST API built as a backend companion for [Movies Manager](https://github.com/MykolaDotsenko/movies-manager).

## What the repository contains

- Controllers for movies, actors, genres, ratings, theaters, and users
- DTOs, entities, services, validation, and Entity Framework migrations
- SQL Server persistence with NetTopologySuite support for spatial data
- JWT and ASP.NET Core Identity packages for authenticated flows
- Azure Blob Storage integration for media
- Swagger/OpenAPI support for exploring endpoints

The `MoviesAPI.csproj` targets **.NET 9**. The repository separates HTTP controllers from DTOs, entities, services, and validation code. These are codebase facts; deployment availability and runtime performance should be checked independently.

## Run locally

```bash
dotnet restore
dotnet run
```

Configure database, authentication, and storage settings for your own environment before running migrations or calling protected and upload endpoints. The repository includes `MoviesAPI.http` for HTTP request examples and `Migrations/` for database schema history.

## Related project

[Movies Manager](https://github.com/MykolaDotsenko/movies-manager) is the Angular frontend built around this API.
