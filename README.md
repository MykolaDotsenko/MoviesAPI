# MoviesAPI

Welcome to **MoviesAPI**, a robust and modern RESTful API for managing movie data, built with clean architecture and industry-standard technologies. This project showcases my ability to design scalable backend systems, implement secure authentication, and integrate advanced features like geospatial queries and cloud storage. Perfect for powering movie catalog apps or learning full-stack development!

## 🚀 Functionality

MoviesAPI provides a comprehensive backend for movie management with the following features:
- **Movie CRUD Operations**: Create, read, update, and delete movies with details like title, release year, synopsis, and more.
- **Genre Management**: Organize movies by genres for easy filtering and categorization.
- **User Authentication**: Secure user registration and login using JWT for protected endpoints.
- **Image Uploads**: Seamlessly upload and retrieve movie posters, integrated with cloud storage.
- **Geospatial Queries**: Find movies by filming locations using spatial data, adding a unique interactive layer.
- **Reviews System**: Allow users to submit and view movie reviews (optional feature).

## 🛠️ Technologies Used

The project leverages cutting-edge tools and frameworks to ensure performance, scalability, and maintainability:
- **ASP.NET Core 8**: A high-performance framework for building RESTful APIs with clean architecture.
- **Entity Framework Core**: ORM for efficient database operations and migrations.
- **SQL Server**: Reliable relational database for storing movie and user data.
- **NetTopologySuite**: Enables geospatial queries for location-based features.
- **Azure Blob Storage**: Scalable cloud storage for movie posters and assets.
- **JWT Authentication**: Secures API endpoints with token-based authentication.
- **Serilog**: Structured logging for monitoring and debugging.
- **Swagger**: API documentation for easy testing and integration.
- **xUnit & Moq**: Unit testing to ensure code reliability.

## 🧠 Implementation Logic

The API follows a **clean architecture** approach, ensuring separation of concerns and maintainability:
- **Controllers**: Handle HTTP requests and responses, keeping endpoints lightweight and focused.
- **Services**: Encapsulate business logic, such as movie validation, genre association, and user management.
- **Repositories**: Abstract database interactions, leveraging EF Core for CRUD operations and spatial queries.
- **DTOs**: Use Data Transfer Objects to optimize data exchange and reduce over-fetching.
- **Dependency Injection**: Enhances modularity and testability by injecting services and repositories.
- **Middleware**: Implements authentication, error handling, and logging for a robust request pipeline.
- **Cloud Integration**: Azure Blob Storage manages file uploads, ensuring scalability for high traffic.

The geospatial feature, powered by NetTopologySuite, allows querying filming locations, adding a unique dimension to the API. Authentication is secured with JWT, protecting sensitive endpoints while maintaining a smooth user experience. The codebase is thoroughly tested with xUnit, ensuring reliability and ease of future enhancements.

## 🌟 Why This Project Shines

MoviesAPI demonstrates my expertise in:
- Designing **RESTful APIs** with scalability and performance in mind.
- Implementing **secure authentication** and data validation.
- Integrating **cloud services** for real-world deployment.
- Writing **clean, testable code** with a focus on maintainability.
- Leveraging advanced features like **geospatial data** to create engaging user experiences.

This project is ready to power a full-stack movie platform or serve as a foundation for further innovation. Check out the code to see my backend development skills in action!

---

**Get Started**:
1. Clone the repository: `git clone https://github.com/MykolaDotsenko/MoviesAPI.git`
2. Configure connection strings in `appsettings.json` (SQL Server, Azure Blob Storage).
3. Run migrations: `dotnet ef database update`
4. Launch the API: `dotnet run`
5. Explore endpoints via Swagger at `https://localhost:5001/swagger`

**Connect**: Feel free to reach out for collaboration 
