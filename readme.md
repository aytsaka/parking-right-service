## Introduction
It is an implementation of a ASP.NET Core Web Api application for parking right registration operations.
This application provides one REST Api endpoints to register a parking right via endpoint `api/parkingright`.

## Prerequisites
- docker-compose
- .NET Core SDK 3.1

## How to run
- Navigate to mysql folder location in command prompt and run command `docker-compose up`
- Navigate to src/ParkingRight.Api folder location in command prompt and run command `dotnet run`
- Navigate to https://localhost:5001/swagger

## Technologies
- AspNet Core 3.1
- EF Core
- MySql
- Docker
- XUnit
- FluentAssertions

## High level design
- ParkingRight.Api - Provides an endpoint to register a parking right.
- ParkingRight.Domain - Keeps domain entities which is developed with DDD pattern.
- ParkingRight.Infrastructure - Repository implementation, infrastructure implementations used by application layer.

## Sources
- https://docs.microsoft.com/en-us/dotnet/architecture/microservices/