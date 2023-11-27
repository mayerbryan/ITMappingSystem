# ITMappingSystem

This is a web API project for managing computer inventory in your company. The API allows you to save, retrieve, update, and delete information about computers, including details like name, model, owner, location, and more.

## Table of Contents

- [Features](#features)
- [Prerequisites](#prerequisites)
- [Getting Started](#getting-started)
  - [Installation](#installation)
  - [Configuration](#configuration)
- [Usage](#usage)
- [API Endpoints](#api-endpoints)
- [Testing](#testing)
- [Contributing](#contributing)
- [License](#license)

## Features

- Create, Read, Update, and Delete (CRUD) operations for computer inventory.
- Store information about computers, including name, model, owner, and location.
- Secure and authenticated access with API keys or JWT tokens.

## Prerequisites

Before you get started, make sure you have the following installed:

- .NET 7 SDK
- Visual Studio Code (or your preferred code editor)
- SQL Server (for database storage)

## Getting Started

### Installation

1. Clone this repository to your local machine.

```
git clone https://github.com/mayerbryan/ITMappingSystem.git
```

Open the project in Visual Studio Code or your preferred code editor.

Install the necessary .NET tools and dependencies by running the following command from the project root:

```
dotnet restore
```

## Configuration

Configure the database connection string in the appsettings.json file to point to your SQL Server instance.

```{
  "ConnectionStrings": {
    "DefaultConnection": "Server=your-server;Database=ComputerInventory;User Id=your-username;Password=your-password;"
  },
  // ...
}
```

Run database migrations to create the necessary tables.

```
dotnet ef database update
```

## Usage

tart the application by running the following command:

```
dotnet run
```

The API should now be accessible at http://localhost:5000 or the specified port in your appsettings.json.

## API Endpoints

Here are the API endpoints for managing computer inventory:

    GET /api/computers: Get a list of all computers.
    GET /api/computers/{computerName}: Get a specific computer by ID.
    POST /api/computers: Create a new computer entry.
    PUT /api/computers/{id}: Update an existing computer.
    DELETE /api/computers/{computerName}: Delete a computer entry.

For detailed information on request and response formats, please refer to the API documentation.

## Testing

You can use tools like Postman or Swagger to test the API endpoints. Ensure that you have valid API keys or JWT tokens for authentication and authorization.
Contributing

If you'd like to contribute to this project, please follow the standard GitHub flow:

    Fork the repository.
    Create a new branch for your feature or fix: git checkout -b feature/your-feature-name
    Commit your changes: git commit -m 'Add feature'
    Push your branch: git push origin feature/your-feature-name
    Create a pull request on GitHub.

## License

This project is licensed under the MIT License - see the LICENSE file for details.