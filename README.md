# EshopModularMonoliths
Modular Monolithic Architecture with .NET

# Dependencies installed using nuget

Use Shared project to instal these:

- dotnet add package Microsoft.Extensions.Configuration.Abstractions
- dotnet add package Microsoft.Extensions.DependencyInjection.Abstractions
- dotnet add package FluentValidation.AspNetCore
- dotnet add package MediatR
- dotnet tool install --global dotnet-ef
- dotnet add package Microsoft.EntityFrameworkCore
- dotnet add package Microsoft.EntityFrameworkCore.Design
- dotnet add package Microsoft.EntityFrameworkCore.Tools
- dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 9.0.4
  
# To run Migrations

- dotnet ef migrations add InitialCreate
  - dotnet ef --startup-project ../../Bootstrapper/Api/Api.csproj migrations add InitialCreate --output-dir ./Data/Migrations --project ./Catalog.csprojs
- dotnet ef database update