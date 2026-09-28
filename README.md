# Auth API

A minimal **ASP.NET Core 8** authentication API: user registration and login with BCrypt password hashing and JWT tokens, backed by EF Core and SQL Server.

## Structure

- Controllers/AuthController.cs — POST /api/auth/register, POST /api/auth/login
- Services/Auth/ — authentication logic
- Common/Result.cs — service result wrapper
- Data/ + Migrations/ — EF Core

## Run

```bash
dotnet ef database update --project AuthHm
dotnet run --project AuthHm
```
