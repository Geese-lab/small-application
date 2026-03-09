# Simple ASP.NET Core Web API

This project is a simple backend API built with ASP.NET Core (.NET 8 LTS).  
It demonstrates a clean layered architecture, dependency injection, logging, and in-memory data storage.

## Features

- ASP.NET Core Web API
- Layered architecture
- Controllers / Services / Repositories / Models
- Dependency Injection
- In-memory data storage
- Logging with ILogger
- Configuration using appsettings.json and environment variables
- Error handling with custom middleware
- Health check endpoint

## Project Structure

SimpleApi
│
├── Controllers
├── Services
├── Repositories
├── Models
├── Middleware
├── Constants
├── appsettings.json
└── Program.cs


## Controllers

- `ProductsController` – CRUD operations for products
- `UsersController` – CRUD operations for users
- `HealthController` – application status endpoint

## Example Endpoints

| Method | Endpoint | Description |
|------|------|------|
| GET | /api/products | Get all products |
| GET | /api/products/{id} | Get product by id |
| POST | /api/products | Create product |
| DELETE | /api/products/{id} | Delete product |
| GET | /api/users | Get all users |
| POST | /api/users | Create user |
| GET | /api/health | Health check |

## Running the Application

Requirements:

- .NET 8 SDK

Run the project:

dotnet run

Open Swagger UI:

https://localhost:5001/swagger


## Configuration

Configuration is handled via:

- `appsettings.json`
- environment variables

Example environment variable override:

AppSettings__Version=2.0


## Logging

Logging is implemented using the built-in ASP.NET Core `ILogger`.

## Data Storage

This project uses **in-memory repositories** instead of a database.