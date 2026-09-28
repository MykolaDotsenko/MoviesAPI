# MoviesAPI

An ASP.NET Core REST API for a movie catalog, built as the backend companion for [Movies Manager](https://github.com/MykolaDotsenko/movies-manager).

The API supports the frontend's movie, actor, genre, theater, rating, authentication, upload, and management workflows. It is most useful in portfolio review as a backend example with explicit controller/DTO/entity/service boundaries, SQL Server persistence, spatial data, media storage, and Swagger/OpenAPI exploration.

## What the repository contains

- REST controllers for movies, actors, genres, ratings, theaters, and users
- DTOs for create/edit/detail/filter/authentication shapes
- Entity Framework Core entities and migrations
- SQL Server persistence
- NetTopologySuite support for theater/geospatial data
- ASP.NET Core Identity and JWT bearer authentication packages
- user/authentication service boundary
- Azure Blob Storage file service for media uploads
- AutoMapper mapping layer
- Swagger/OpenAPI support
- `MoviesAPI.http` request examples

## Backend boundaries visible in the code

| Layer | Examples |
| --- | --- |
| HTTP/API | `Controllers/MoviesController.cs`, `ActorsController.cs`, `GenresController.cs`, `TheatersController.cs`, `RatingsController.cs`, `UsersController.cs` |
| Request/response contracts | `DTOs/MovieCreationDTO.cs`, `MoviesFilterDTO.cs`, `AuthenticationResponseDTO.cs`, `TheaterDTO.cs` |
| Domain persistence | `Entities/Movie.cs`, `Actor.cs`, `Genre.cs`, `Theater.cs`, `Rating.cs` |
| Services | `Services/UsersService.cs`, `Services/AzureFileStorage.cs` |
| Database history | `Migrations/` |
| API exploration | Swagger/OpenAPI packages and `MoviesAPI.http` |

## Relationship to Movies Manager

[Movies Manager](https://github.com/MykolaDotsenko/movies-manager) is the Angular frontend that consumes this API. Together, the two repositories show the complete catalog flow:

1. Angular forms and management screens collect movie, actor, genre, theater, image, rating, and user input.
2. MoviesAPI validates and maps request DTOs.
3. Entity Framework persists catalog, relationship, user, rating, and theater data.
4. Spatial theater data and uploaded media support map and poster workflows.
5. Authenticated routes use Identity/JWT-related infrastructure.

## Stack

- ASP.NET Core / .NET 9
- C#
- Entity Framework Core
- SQL Server
- NetTopologySuite
- ASP.NET Core Identity
- JWT bearer authentication
- Azure Blob Storage
- AutoMapper
- Swagger / Swashbuckle

## Run locally

```bash
dotnet restore
dotnet run
```

Configure database, authentication, CORS, and storage settings for your own environment before running migrations or calling protected and upload endpoints.

## Deployment note

The repository has been used with an Azure App Service Swagger URL:

https://moviesapi20250415161440-ahfxgzdpb8e4dbgk.canadacentral-01.azurewebsites.net/swagger/index.html

Deployment availability can change independently of the repository, so validate the endpoint before relying on it in a demo.
