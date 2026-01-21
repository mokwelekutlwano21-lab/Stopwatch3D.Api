1. Document Information
Item	Description
Project Name	3D Stopwatch with Weather Focus
Document Type	System Architecture
Version	1.0
Author	Kutlwano Mokwele
Tools	Visual Studio Code, ASP.NET Core Web API
Date	21 January 2026
2. Architectural Overview

The 3D Stopwatch with Weather Focus system follows a layered architecture based on REST principles.
The architecture separates concerns between the presentation layer, API layer, business logic, and external services.

This design improves:

Maintainability

Scalability

Testability

Clear separation of responsibilities

3. Architecture Style

Architecture Pattern:

Layered Architecture

RESTful API

Supporting Principles:

Separation of Concerns

Stateless Services

Single Responsibility Principle

4. High-Level Architecture Diagram (Textual)
+----------------------------+
|        Client Layer        |
|----------------------------|
| - Web Browser              |
| - 3D Stopwatch UI          |
| - Swagger UI               |
+-------------+--------------+
              |
              | HTTP/HTTPS
              |
+-------------v--------------+
|        API Layer            |
|----------------------------|
| - StopwatchController      |
| - WeatherController        |
| - RequirementsController  |
+-------------+--------------+
              |
              |
+-------------v--------------+
|     Business Logic Layer    |
|----------------------------|
| - Stopwatch Service        |
| - Weather Service          |
| - Time Calculation Logic   |
+-------------+--------------+
              |
              |
+-------------v--------------+
|   External Services Layer   |
|----------------------------|
| - Weather API              |
| - System Clock             |
+----------------------------+

5. Layer Descriptions
5.1 Client Layer

Responsible for user interaction and visualization.

Components:

Web Browser

Swagger UI (API testing)

3D Stopwatch Interface (future UI layer)

Responsibilities:

Send API requests

Display stopwatch time

Display weather information

Render 3D visuals

5.2 API Layer

Acts as the communication gateway between clients and the system.

Components:

StopwatchController

WeatherForecastController

RequirementsController

Responsibilities:

Handle HTTP requests

Validate input

Return JSON responses

Expose REST endpoints

5.3 Business Logic Layer

Contains core application logic.

Components:

Stopwatch timing logic

Weather data processing

Validation rules

Responsibilities:

Calculate elapsed time

Manage stopwatch state

Process weather information

5.4 External Services Layer

Handles third-party and system dependencies.

Components:

Weather API service

System DateTime / Clock

Responsibilities:

Provide weather data

Provide accurate time source

6. Technology Stack
Layer	Technology
Client	Browser, Swagger UI
API	ASP.NET Core Web API
Business Logic	C#
Documentation	Swagger, Markdown
Development Tool	Visual Studio Code
7. Communication Flow

User interacts with the client (Swagger UI or 3D UI)

Client sends HTTP request to API

API controller calls business logic

Business logic processes request

API returns JSON response to client

Client displays result

8. Security Architecture

Stateless API design

HTTPS supported

Input validation at controller level

No sensitive data stored in memory

9. Deployment Architecture
+-----------------------+
| Client (Browser)      |
+----------+------------+
           |
           |
+----------v------------+
| ASP.NET Core Web API  |
| (Kestrel Server)     |
+-----------------------+

10. Scalability Considerations

Stateless API enables horizontal scaling

Business logic can be extracted into services

Weather service can be replaced or cached

UI can evolve independently (3D UI)

11. Architectural Decisions
Decision	Reason
Layered Architecture	Clear separation of concerns
REST API	Standard, scalable communication
Swagger	Easy testing and documentation
Markdown Docs	Version control friendly
12. Future Architecture Enhancements

Add database layer for history tracking

Introduce authentication and authorization

Use caching for weather data

Deploy to cloud (Azure / AWS)

Integrate real-time updates (SignalR)

13. Conclusion

This architecture provides a clean, scalable, and maintainable foundation for the 3D Stopwatch with Weather Focus system, supporting future expansion while maintaining simplicity.