#Project Overview
This project is a comprehensive system for managing albums, bands, songs, and band members. It integrates various technologies and follows a three-tier architecture to deliver functionality through both desktop and web applications.

##Technologies Used

###Frontend
- Angular: For the portal interface.

###Backend
- ASP.NET Web API: For handling business logic and RESTful communication.
- WinForms: Provides a desktop interface that interacts with the backend.
- C#: Main programming language used.
- ADO.NET: For database operations.
- SOAP Web Services: Used for WinForms to communicate with the server.

###Database
SQL Server 2019 Express: Manages data storage and retrieval.

##Architecture
The project follows a 3-tier logical architecture and an N-Tier physical architecture:

- Server Component: Handles business logic and database interaction.
- Web Component (IIS Server): Hosts the Angular application.
- Client Component (WinForms): Manages the desktop UI and communicates with the server through web services.
