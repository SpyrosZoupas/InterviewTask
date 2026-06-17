# Fines Management API

A RESTful API for managing fines information, built with ASP.NET Core 8.0 and featuring a React frontend client.

## Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- [Visual Studio/Visual Studio Community](https://visualstudio.microsoft.com/vs/) or [Visual Studio Code](https://code.visualstudio.com/)

## Getting Started

### Running the API

#### Option 1: Using Visual Studio

1. Open `ZenithInterviewTask.sln` in Visual Studio
2. Set `Fines.Api` as the startup project
3. Press `F5` or click the **Run** button

#### Option 2: Using .NET CLI

```powershell
# Navigate to the API project directory
cd Fines.Api\Fines.Api

# Restore dependencies
dotnet restore

# Run the application
dotnet run
```

The API will be available at:
- HTTP: `http://localhost:5200`
- HTTPS: `https://localhost:7200`
- Swagger UI: `https://localhost:7200/swagger`


## API Documentation

### Base URL

- HTTPS: `https://localhost:7200`
- HTTP: `http://localhost:5200`

### Endpoints

#### Get All Fines

Retrieves a list of all fines in the system.

**Endpoint:** `GET /api/fines`

**Response:** `200 OK`

```json
[
  {
    "id": 1,
    "fineNo": "FN-2024-001",
    "fineDate": "2024-12-01T00:00:00",
    "fineType": "Parking",
    "vehicleRegNo": "ABC123",
    "vehicleDriverName": "John Doe"
  }
]
```

### Swagger Documentation

Interactive API documentation is available via Swagger UI when running in development mode:

- Navigate to: `https://localhost:7200/swagger`

## Technologies Used

- **[ASP.NET Core 8.0](https://learn.microsoft.com/en-us/aspnet/core/?view=aspnetcore-8.0)** - Web framework
- **[Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)** - ORM for data access
- **[In-Memory Database](https://learn.microsoft.com/en-us/ef/core/providers/in-memory/)** - For development and testing
- **[Swashbuckle (Swagger)](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)** - API documentation
- **[xUnit](https://xunit.net/)** - Testing framework
- **[Moq](https://github.com/moq/moq4)** - Mocking library for unit tests

## Data Model

The API uses the following entities:

- **FinesEntity** - Contains fine records with references to vehicles
- **VehicleEntity** - Stores vehicle information (registration number, make, model, color, year, VIN, engine size, fuel type, insurance and MOT expiry dates)
- **CustomerEntity** - Contains customer details (name, email, phone, address, date of birth, driver license number)

### Development Notes

1. The application uses an **in-memory database** which is seeded on startup with 25 fines, 25 vehicles, and 25 customers
2. Data will be lost when the application restarts
3. **CORS is configured to allow all origins** - this should be restricted in production
