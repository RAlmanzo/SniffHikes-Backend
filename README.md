# 🐾 SniffHikes Backend

A scalable and modular GraphQL backend API built for the SniffHikes Mobile App, targeting dog-friendly hiking events and community sharing.

**This backend is currently under active development and will serve as the foundation for the upcoming .NET MAUI mobile version of the SniffHikes app.**

---

## 📘 Description

The SniffHikes Backend is a clean, testable, and maintainable server-side application that provides a GraphQL API to power the SniffHikes mobile app. Build with a Clean/Onion Architecture, it ensures a clear separation of concerns between business logic, infrastructure, and delivery.

This API will be integrated with Firebase realtime database for data , firebase storage for images and authentication using Firebase Auth and JWT tokens for secure access.

It replaces the original backend logic and is designed specifically to support the upcoming .NET MAUI mobile rewrite of the app (previously developed in Xamarin.Forms).

---

## 🧱 Architecture

Follows Clean Architecture / Onion Architecture with the following layers:

📦 SniffHikes-Backend/

├── 📁 SniffHikes-Backend.API             --> GraphQL endpoints (HotChocolate)

├── 📁 SniffHikes-Backend.Core            --> Domain models, interfaces, business logic

├── 📁 SniffHikes-Backend.Infrastructure --> Firebase integration, repositories, services

├── 📁 SniffHikes-Backend.Tests           --> Unit tests (planned with xUnit + mocking)

---

## 🚀 Tech Stack

### ✅ Core Technologies

- .NET 8

- GraphQL with HotChocolate

- Firebase:

 -- Realtime Database (for user data, events, comments, routes, etc.)

 -- Firebase Storage (for images and assets)

 -- Firebase Authentication (OAuth, email/password)

 -- JWT Tokens for secured API access

 -- GitHub Actions for CI/CD pipeline

 -- Unit Testing with xUnit & Moq (planned)

---

## 🔐 Authentication & Authorization

Firebase Authentication will be used to validate users implemented at the frontend (.NET Maui app).

On successful login, a Firebase JWT token will be issued and verified on the API side.

The API will expose both public and authorized GraphQL queries/mutations.

Future implementation of role-based policies for admin features.

---

## 📦 Features (Planned & In Progress)

✅ Modular Onion Architecture

✅ GitHub Actions for CI build

🛠 GraphQL endpoint using HotChocolate

🛠 Firebase integration for data and storage

🛠 Secure JWT-based authentication (Firebase tokens)

🧪 Unit tests for core services

🚀 API to be consumed by a .NET MAUI mobile app

---

## 🧠 What I’m Learning

- Structuring scalable backends using Clean Architecture

- Working with GraphQL APIs in .NET

- Integrating with Firebase services in a .NET environment

- Setting up secure authentication flows using Firebase Auth and JWT

- Writing unit tests for services using xUnit and mocking

- Creating CI/CD pipelines with GitHub Actions

- Preparing for mobile-first architecture using .NET MAUI

---

### ⚙️ GitHub Actions

This project includes a GitHub Actions workflow to automatically:

- Build the backend on every push or pull request to main or dev

**To be added later:**

- Run future unit tests to ensure code stability

 -Auto deploy on push and pull-request to main(production) branch

---

## 🔧 Setup & Running

### Prerequisites

- .NET 8 SDK

- Firebase Project (Realtime DB, Auth, Storage)

- Firebase Admin SDK Key (for server-side integration)

- Install dependencies
```Bash
dotnet restore
```

- Run the API
```bash
dotnet run --project SniffHikes.API
```

- GraphQL Playground

Visit: https://localhost:5001/graphql or http://localhost:5000/graphql
(depending on your HTTPS settings)

---

## 📈 Future Roadmap

 - Complete GraphQL CRUD operations for events, users, routes, comments

 - Add full JWT validation using Firebase Admin SDK

 - Implement file/image upload to Firebase Storage

 - Add admin role management and restrictions

 - Migrate mobile app to .NET MAUI and connect it to this backend

 - Deploy to cloud hosting (e.g., Render, Azure)

---

## 📬 Contact
Want to connect or ask questions?

📧 Email: ralmanzo@gmail.com

💼 LinkedIn: https://www.linkedin.com/in/rosseel-almanzo-5241172ba/

🐙 GitHub: https://github.com/RAlmanzo
