# Product Management API

En REST API byggd med ASP.NET Core och Clean Architecture.

## Tekniker

- ASP.NET Core Web API
- Entity Framework Core
- SQL Server LocalDB
- MediatR
- Swagger/OpenAPI
- Clean Architecture

## Funktioner

### Products

- GET /api/Products
- GET /api/Products/{id}
- POST /api/Products
- PUT /api/Products/{id}
- DELETE /api/Products/{id}

## Databas

Projektet använder SQL Server LocalDB.

Connection string finns i:

```json
appsettings.json
```

## Starta projektet

```bash
dotnet restore
dotnet build
dotnet run --project ProductManagementAPI.API
```

Swagger öppnas på:

```
http://localhost:5224/swagger
```

## Arkitektur

### API
Innehåller Controllers och konfiguration.

### Application
Innehåller Commands, Queries och Handlers.

### Domain
Innehåller Entities och Interfaces.

### Infrastructure
Innehåller Entity Framework Core, DbContext och Repositories.