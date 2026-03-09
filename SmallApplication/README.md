# Simple ASP.NET Core Web API

This project is a backend API built with .NET 8 (LTS) using ASP.NET Core Web API.
It demonstrates a clean layered architecture, dependency injection, logging, testing, CI/CD, and cloud deployment to Azure.

The application provides simple CRUD functionality using in-memory storage and exposes REST endpoints.

## Features

- ASP.NET Core Web API
- Layered architecture (Controllers, Services, Repositories, Models)
- Dependency Injection
- In-memory data storage
- Logging with ILogger
- Configuration via appsettings.json and environment variables
- Global error handling with custom middleware
- Health check endpoint
- Unit tests
- CI/CD pipeline with GitHub Actions
- Deployment to Azure App Service

## Project Structure

The project follows a simple layered architecture.

Controllers handle HTTP requests and responses.
Services contain business logic.
Repositories abstract the data access layer.
Models define the data structures.

SmallApplication
│
├── Controllers
│   ├── ProductsController.cs
│   ├── UsersController.cs
│   └── HealthController.cs
│
├── Services
│   ├── Interfaces
│   └── Implementations
│
├── Repositories
│   ├── Interfaces
│   └── InMemory implementations
│
├── Models
│
├── Middleware
│   └── ExceptionMiddleware.cs
│
├── Constants
│
├── appsettings.json
└── Program.cs


## Controllers

- `ProductsController` – CRUD operations for products
- `UsersController` – CRUD operations for users
- `HealthController` – application status endpoint

## API Endpoints

| Method | Endpoint | Description |
|------|------|------|
| GET | /api/products | Get all products |
| GET | /api/products/{id} | Get product by id |
| POST | /api/products | Create product |
| DELETE | /api/products/{id} | Delete product |
| GET | /api/users | Get all users |
| POST | /api/users | Create user |
| GET | /api/health | Health check |

Example response:

{
  "status": "Healthy"
}

##Running the Application

Requirements

- .NET 8 SDK

Run the API locally:

dotnet restore
dotnet build
dotnet run

Swagger UI will be available at:

https://localhost:5001/swagger


## Configuration

Configuration is handled via:

- appsettings.json

- environment variables

Example configuration file:

{
  "AppSettings": {
    "ApplicationName": "Simple API",
    "Version": "1.0"
  }
}

Environment variables can override these values.

Example:

AppSettings__Version=2.0


## Logging

Logging is implemented using the built-in ASP.NET Core logging system (ILogger).

Example log levels:

- Information

- Warning

- Error

Logs are written to the console by default.

## Error Handling

Global error handling is implemented using custom middleware.

The middleware catches unhandled exceptions and returns a standardized response.

Example response:

{
  "message": "Internal server error"
}

## Data Storage

The application uses in-memory repositories instead of a database.

This keeps the project simple and allows it to run without external dependencies.

## Testing

Unit tests are implemented using the xUnit testing framework.

The tests verify the service layer logic and repository interactions.

Run tests locally:

dotnet test

Example tested scenarios:

- retrieving products

- creating products

- retrieving entities by ID

## CI/CD Pipeline

Continuous Integration and Deployment is implemented using GitHub Actions.

The pipeline runs automatically on push to the main branch.

Pipeline steps:

1. Checkout repository
2. Setup .NET
3. Restore dependencies
4. Build project
5. Run tests
6. Publish application
7. Deploy to Azure App Service

Workflow location:

.github/workflows/ci-cd.yml

Sensitive values are stored securely using GitHub Secrets.

## Environment Variables in Azure

Application configuration in Azure is managed using Application Settings (environment variables).

Example variables:

|Name|Value|
|-----|-----|
|AppSettings__ApplicationName|Simple API|
|AppSettings__Version|1.0|

These override values defined in appsettings.json.

## Technologies Used

- .NET 8 (LTS)
- ASP.NET Core Web API
- xUnit
- GitHub Actions
- Azure App Service

## Author

Backend Web API project demonstrating modern .NET backend development practices including architecture, CI/CD, testing, and cloud deployment.