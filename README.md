# Court Booking API

A REST API for booking badminton courts at a single venue, built with ASP.NET Core and EF Core. Players book a court for one or two hours, and the API enforces the venue's rules: no double-booking, opening hours only, and cancellation up to 24 hours before the start.

> 🚧 Work in progress: a learning project, built step by step.

## Booking rules (v1)

- One venue with several courts, open **06:00–22:00**.
- A booking is **1 or 2 whole hours**, starting on the hour.
- A court can't have two bookings that **overlap**.
- No bookings in the past or outside opening hours.
- A player can **cancel up to 24 hours** before the start. A cancelled booking frees the court.

## Tech stack

- ASP.NET Core Web API (controllers), .NET 10
- Entity Framework Core (code-first, migrations), SQL Server
- xUnit for tests

## Getting started

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- SQL Server (local instance)
- EF Core CLI: `dotnet tool install --global dotnet-ef`

### Configure the connection string

The connection string is stored in [User Secrets](https://learn.microsoft.com/aspnet/core/security/app-secrets), never in `appsettings.json` or git. From the project folder:

```bash
dotnet user-secrets set "ConnectionStrings:CourtBooking" "<your SQL Server connection string>"
```

### Run

```bash
dotnet run
```

## Endpoints

_Coming soon._
