| Item          | Description                                       |
| ------------- | ------------------------------------------------- |
| Project Name  | 3D Stopwatch with Weather Focus                   |
| Document Type | Software Requirement Model                        |
| Version       | 1.0                                               |
| Tools Used    | Visual Studio Code, ASP.NET Core Web API, Swagger |
| Author        | Kutlwano Mokwele                                  |
| Date          | 21 January 2026                                   |

2. System Overview

The 3D Stopwatch with Weather Focus System is a web-based application that provides stopwatch functionality combined with real-time weather information.
The system exposes RESTful API endpoints to control the stopwatch and retrieve weather data, while a 3D user interface visually represents the stopwatch.

3. System Objectives

Provide accurate stopwatch timing

Allow users to start, stop, reset, and view elapsed time

Display current weather conditions

Support a 3D stopwatch visualization

Enable API testing using Swagger UI

| Stakeholder       | Role                                    |
| ----------------- | --------------------------------------- |
| User              | Uses the stopwatch and weather features |
| Developer         | Implements system functionality         |
| Lecturer / Marker | Evaluates system correctness            |
| Tester            | Tests API functionality                 |

| ID    | Requirement Description                                         |
| ----- | --------------------------------------------------------------- |
| FR-01 | The system shall allow the user to start the stopwatch.         |
| FR-02 | The system shall allow the user to stop the stopwatch.          |
| FR-03 | The system shall allow the user to reset the stopwatch to zero. |
| FR-04 | The system shall display the current elapsed time.              |
| FR-05 | The system shall retrieve and display weather information.      |
| FR-06 | The system shall expose stopwatch endpoints via a REST API.     |
| FR-07 | The system shall support real-time stopwatch updates.           |

| ID     | Requirement Description                                         |
| ------ | --------------------------------------------------------------- |
| NFR-01 | The system shall respond to API requests within real time.      |
| NFR-02 | The system shall be accessible via a web browser.               |
| NFR-03 | The system shall support a 3D graphical stopwatch interface.    |
| NFR-04 | The system shall be scalable for future feature additions.      |
| NFR-05 | The system shall use Swagger for API documentation and testing. |

| Constraint ID | Description                                              |
| ------------- | -------------------------------------------------------- |
| SC-01         | The system must be developed using ASP.NET Core Web API. |
| SC-02         | The system must be developed in Visual Studio Code.      |
| SC-03         | The system must use HTTP/HTTPS protocols.                |
| SC-04         | The system must follow REST architectural principles.    |

| API Endpoint                | Description            | Requirement ID |
| --------------------------- | ---------------------- | -------------- |
| POST `/api/stopwatch/start` | Starts the stopwatch   | FR-01          |
| POST `/api/stopwatch/stop`  | Stops the stopwatch    | FR-02          |
| POST `/api/stopwatch/reset` | Resets the stopwatch   | FR-03          |
| GET `/api/stopwatch/time`   | Retrieves elapsed time | FR-04          |
| GET `/weatherforecast`      | Retrieves weather data | FR-05          |

9. Assumptions and Dependencies

Users have internet access

The system runs on a modern web browser

Weather data depends on a weather service or API

Stopwatch timing depends on server availability

10. Future Enhancements

User authentication

Location-based weather

Stopwatch history tracking

Mobile device support

Cloud deployment

| Name | Role | Signature | Date |
| ---- | ---- | --------- | ---- |
|      |      |           |      |
