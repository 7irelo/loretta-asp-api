# Loretta Bank API

![loretta_home](https://github.com/user-attachments/assets/020920f9-7df1-4090-93e4-cff8b341ab46)
![loretta_transfer](https://github.com/user-attachments/assets/817f8b9f-13e4-499b-9ffe-33f44329045b)
![loretta_login](https://github.com/user-attachments/assets/8cc80f60-74c2-4a40-a863-2490ceb3a5a0)
![loretta_load](https://github.com/user-attachments/assets/dfd0bd1a-761e-4c9f-a6c0-5451cbf64428)

Welcome to Loretta Bank, an online banking application built with ASP.NET Core and PostgreSQL. Loretta Bank offers a secure, user-friendly platform for managing your banking needs online.

## Table of Contents

- [Features](#features)
- [Tech Stack](#tech-stack)
- [Installation](#installation)
- [Usage](#usage)
- [API Endpoints](#api-endpoints)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)
- [Folder Structure](#folder-structure)

## Features

- User Authentication (Sign Up, Log In, Log Out)
- Account Management (Create, View, Update, Delete Accounts)
- Fund Transfers (Internal and External)
- Transaction History
- Balance Inquiries
- Responsive Design

## Tech Stack

- **Backend**: ASP.NET Core
- **Database**: PostgreSQL
- **Authentication**: JWT (JSON Web Tokens)
- **Styling**: CSS, Bootstrap

## Installation

### Prerequisites

- .NET 6.0 SDK or later
- PostgreSQL
- Docker and Docker Compose (optional)

### Steps

1. Clone the repository:

    ```bash
    git clone https://github.com/7irelo/loretta-asp-api.git
    cd loretta-asp-api
    ```

2. Set up PostgreSQL:

    ```bash
    psql -U postgres -c "CREATE DATABASE loretta_bank;"
    psql -U postgres -c "CREATE USER loretta_user WITH PASSWORD 'password';"
    psql -U postgres -c "GRANT ALL PRIVILEGES ON DATABASE loretta_bank TO loretta_user;"
    ```

3. Update the `appsettings.json` file with your database connection string:

    ```json
    {
      "ConnectionStrings": {
        "DefaultConnection": "Host=localhost;Database=loretta_bank;Username=loretta_user;Password=password"
      },
      "Jwt": {
        "Key": "your_jwt_secret_key",
        "Issuer": "loretta_bank",
        "Audience": "loretta_bank_users",
        "ExpiresInMinutes": 60
      }
    }
    ```

4. Run the application:

    ```bash
    dotnet build
    dotnet run
    ```

### Docker Setup (Optional)

1. Build and start the containers:

    ```bash
    docker-compose up --build
    ```

2. The application will be accessible at `http://localhost:5000`.

## Usage

- Access the API via `http://localhost:5000/api/`
- Use tools like Postman or Curl to interact with the endpoints.
- Authenticate using the `/auth/login` endpoint to obtain a JWT token, which should be included in the `Authorization` header for subsequent requests.

## API Endpoints

### Authentication

- `POST /api/auth/register` - Register a new user
- `POST /api/auth/login` - Log in a user
- `GET /api/auth/me` - Fetch logged in user
- `PUT /api/auth/logout` - Log out a user

### Accounts

- `GET /api/accounts` - Get all accounts for the authenticated user
- `POST /api/accounts` - Create a new account
- `GET /api/accounts/{id}` - Get a specific account
- `PUT /api/accounts/{id}` - Update a specific account
- `DELETE /api/accounts/{id}` - Delete a specific account

### Transactions

- `GET /api/transactions` - Get all transactions for the authenticated user
- `POST /api/transactions` - Create a new transaction
- `GET /api/transactions/{id}` - Get a specific transaction
- `PUT /api/transactions/{id}` - Update a specific transaction
- `DELETE /api/transactions/{id}` - Delete a specific transaction

### Cards

- `GET /api/cards` - Get all cards for the authenticated user
- `POST /api/cards` - Create a new card
- `GET /api/cards/{id}` - Get a specific card
- `PUT /api/cards/{id}` - Update a specific card
- `DELETE /api/cards/{id}` - Delete a specific card

### Loans

- `GET /api/loans` - Get all loans for the authenticated user
- `POST /api/loans` - Create a new loan
- `GET /api/loans/{id}` - Get a specific loan
- `PUT /api/loans/{id}` - Update a specific loan
- `DELETE /api/loans/{id}` - Delete a specific loan

### Customer Support

- `GET /api/support` - Get all support tickets for the authenticated user
- `POST /api/support` - Create a new support ticket
- `GET /api/support/{id}` - Get a specific support ticket
- `PUT /api/support/{id}` - Update a specific support ticket
- `DELETE /api/support/{id}` - Delete a specific support ticket

## Contributing

Contributions are welcome! Please follow these steps to contribute:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/your-feature-name`).
3. Commit your changes (`git commit -m 'Add some feature'`).
4. Push to the branch (`git push origin feature/your-feature-name`).
5. Open a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact

For any inquiries or issues, please contact us at [support@lorettabank.com](mailto:support@lorettabank.com).

## Folder Structure

```
loretta-bank-api/
├── LorettaBank.Api/          # ASP.NET Core API project
│   ├── Controllers/          # API Controllers
│   ├── Models/               # Data models
│   ├── Services/             # Business logic
│   ├── Data/                 # Database context and migrations
│   ├── appsettings.json      # Configuration settings
│   └── Startup.cs            # Application startup configuration
├── LorettaBank.Tests/        # Unit and integration tests
├── docker-compose.yml        # Docker Compose configuration
└── README.md
```

---

This README should now be suitable for an ASP.NET Core backend project for the Loretta Bank application.
