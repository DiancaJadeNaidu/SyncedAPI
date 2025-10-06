# SyncedAPI

[![.NET](https://img.shields.io/badge/.NET-9.0-blue)](https://dotnet.microsoft.com/)  
[![License: MIT](https://img.shields.io/badge/License-MIT-green)](LICENSE)  

A RESTful API built with .NET to manage **game scores**, providing endpoints for recording results, retrieving leaderboards, and supporting multiplayer competition tracking. 
This project uses **MongoDB** as its primary database and is hosted on **Render** for cloud deployment.

---

## Group Members  

- Member 1: Dianca Jade Naidu  
- Member 2: Riva Jangda  
- Member 3: Keira Meth  
- Member 4: Azande Mnguni  
- Member 5: Asanda Dimba  

---

## Table of Contents  

1. [Overview](#overview)  
2. [Features](#features)  
3. [Architecture & Structure](#architecture--structure)  
4. [Prerequisites](#prerequisites)  
5. [Setup & Installation](#setup--installation)  
6. [Environment & Configuration](#environment--configuration)  
7. [Database (MongoDB)](#database-mongodb)  
8. [Hosting (Render)](#hosting-render)  
9. [Running the Application](#running-the-application)  
10. [API Usage & Endpoints](#api-usage--endpoints)  
11. [Data Models](#data-models)  
12. [Testing](#testing)  
13. [Docker / Deployment](#docker--deployment)  
14. [Error Handling & Logging](#error-handling--logging)  
15. [Contributing](#contributing)  
16. [License](#license)  
17. [Contact / Support](#contact--support)  
18. [References](#references)  

---

## Overview  

GameScoresAPI is a .NET-based backend service designed to **record, update, and retrieve game scores** for competitive play.  
It supports modular integration with gaming applications, enabling real-time score tracking, leaderboard generation, and historical match records.  

---

## Features  

- Submit scores for individual players or teams  
- Retrieve leaderboards (daily, weekly, overall)  
- Update or delete incorrect score entries  
- Manage player profiles and match history  
- Scalable and reliable data synchronization  
- Supports integration with web and mobile games  

---

## Architecture & Structure  

Here’s a quick look at the folder structure and project layout:  

- **Controllers** — API controllers / endpoints  
- **Data** — database context, migrations, seed data  
- **Models** — domain or DTO classes (e.g., Score, Player)  
- **Repositories** — interface & implementation for data access  
- **Program.cs** — the entry point, configures services, middleware, routing  
- **GameScoresAPI.http** — optional file for testing HTTP calls (similar to a Postman collection)  
- **Dockerfile** — containerization instructions  

---

## Prerequisites  

Before running the project, ensure you have:  

- [.NET SDK 9.0 (or matching version used in the project)](https://dotnet.microsoft.com/download)  
- (Optional) A database engine (e.g. SQL Server, SQLite, PostgreSQL) if not using in-memory DB  
- Docker (if you want to build/run via container)  
- A code editor or IDE that supports C# / .NET (e.g. Visual Studio, Visual Studio Code)  

---

## Setup & Installation  

```bash
git clone https://github.com/DiancaJadeNaidu/SyncedAPI.git

cd SyncedAPI

dotnet restore
dotnet build
dotnet ef database update
```
---

## Configuration

# Environment & Configuration

-Configuration files:

appsettings.json → default application config

appsettings.Development.json → overrides for development

-Example:
```bash
{
"ConnectionStrings": {
"DefaultConnection": "YourDatabaseConnectionHere"
},
"Logging": {
"LogLevel": {
"Default": "Information",
"Microsoft": "Warning"
}
}
}
```
---
## Database (MongoDB)
**MongoDB** is used to store scores, players and leaderboard data. For Local deployment, install MongoDB
Community Server or connect to a hosted instance using MongoDB Atlas. Connection strings are set in .env file.

---
## Hosting (Render)
API is deployed on Render, making it publicly accessible. Render automatically builds and runs the project
using the Dockerfile.

## Running the Application

dotnet run --project SyncedAPI

API will start at:

http://localhost:5000

https://localhost:5001

---

## API Usage & Endpoints

| Method | Endpoint         | Description                  |
| ------ | ---------------- | ---------------------------- |
| GET    | /api/scores      | Get all scores               |
| GET    | /api/scores/{id} | Get score by ID              |
| POST   | /api/scores      | Submit a new score           |
| PUT    | /api/scores/{id} | Update a score entry         |
| DELETE | /api/scores/{id} | Remove a score               |
| GET    | /api/leaderboard | Retrieve current leaderboard |


---

## Data Models

Located under /Models.

Example:

public class Score
{
    public int Id { get; set; }
    public string PlayerName { get; set; }
    public int Points { get; set; }
    public DateTime MatchDate { get; set; }
}


---

## Testing

dotnet test

Use SyncedAPI.http for manual endpoint testing

Recommended: use xUnit/NUnit with InMemoryDatabase

---

## Docker Usage

docker build -t syncedapi .
docker run -d -p 5000:80 syncedapi

---

## Error Handling & Logging

Logging configured in appsettings.json

Centralized error handling middleware recommended

Returns consistent status codes (400, 404, 500, etc.)

---

## Contributing

Fork repo

Create branch: git checkout -b feature/my-feature

Commit: git commit -m "Add new feature"

Push: git push origin feature/my-feature

Open Pull Request

---

## Contact

Maintainer: Dianca Jade Naidu
GitHub: https://github.com/DiancaJadeNaidu

Repo: https://github.com/DiancaJadeNaidu/SyncedAPI

---

## References

Microsoft (2025) ASP.NET Core Web API documentation. Available at: https://learn.microsoft.com/aspnet/core/web-api
 (Accessed: 6 October 2025).

RESTfulAPI.net (2025) REST API design patterns. Available at: https://restfulapi.net/
 (Accessed: 6 October 2025).

Microsoft (2025) Entity Framework Core documentation. Available at: https://learn.microsoft.com/ef/core/
 (Accessed: 6 October 2025).

Render (2025) Cloud application hosting for developers. Available at: https://render.com/
 (Accessed: 6 October 2025).

MongoDB (2025) MongoDB documentation. Available at: https://www.mongodb.com/docs/
 (Accessed: 6 October 2025).
