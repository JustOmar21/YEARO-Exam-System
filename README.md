# YEARO Exam System

## Overview
YEARO Exam System is a comprehensive exam management solution designed with a robust database backend that handles the full exam lifecycle—including administration, exam creation, automated grading, and detailed reporting. A Windows Forms desktop client is provided as a user-friendly interface, exposing a subset of these database functionalities for everyday use by instructors, students, and administrators.

## System Architecture
The system is divided into two main components:

1. **Database Functionalities:**  
   The core logic and complete set of features reside in the database. This layer handles data storage, business rules, and all operations related to exam management, user management, automated grading, and reporting. It is maintained through a collection of TSQL scripts, stored procedures.

2. **Desktop Application:**  
   A Windows Forms client that interfaces with the database. The desktop application provides an intuitive UI for users to interact with a subset of the database functionalities—focusing on exam participation, exam scheduling, basic exam management, questions management, and report viewing. While it includes limited administrative features, the full spectrum of admin capabilities is managed at the database level.

## Database Functionalities
Located in the `DATABASE` folder, this component is responsible for the entire business logic and data handling of the exam system. It includes:

- **Schema Definitions:**  
  TSQL scripts to create tables, define relationships, and set up constraints necessary for the exam system or you can use the backup already full of data.

- **Stored Procedures & Functions:**  
  Core operations such as:
  - Exam creation and question management
  - User registration and role management (administrative, instructor, student)
  - Automated grading and score calculation
  - Data aggregation for reporting

- **Administrative Tools:**  
  Scripts that support system-wide tasks like bulk data management, configuration updates, and advanced reporting functions.

These components ensure that all exam-related operations—from creation to evaluation and reporting—are consistently managed at the database level.

## Desktop Application Functionalities
The `Desktop` folder contains the Windows Forms application which acts as a client to the database. It offers a user-friendly interface for the following tasks:

- **User Interaction:**  
  - **Students:**  
    Log in to access their courses and complete its assigned exams, with results provided immediately through automated grading.
  - **Instructors:**  
    Create, schedule, and manage exams and questions, as well as review students performance.
  - **Administrators:**  
    Perform administrative tasks that mainly consist of reports and reviewing students and instructors data through the application interface, though the full range of admin features is available directly in the database layer.

## Additional Components
- **ALL_REPORTS:**  
  Contains report templates and definitions that generate detailed analytics on exam performance and student outcomes.

- **images:**  
  Stores visual assets such as screenshots and architecture illustrations.

- **EMAILS-TEST.txt:**  
  Provides sample email configurations for testing and verifying the system’s email notification features.

- **.gitignore:**  
  Lists files and directories to be excluded from version control.

## Installation & Setup

### Prerequisites
- **Development Environment:**  
  Microsoft Visual Studio 2017 or later
- **.NET Framework:**  
  .NET 9
- **Database:**  
  Microsoft SQL Server (local or remote instance)

### Setup Instructions
1. **Database Setup:**
   - Navigate to the `DATABASE` folder.
   - Restore the database using the .bak file or execute the provided TSQL scripts to create and initialize the database schema, stored procedures, and other objects.
   - Update the connection string in the desktop application’s configuration file to point to your SQL Server instance.

2. **Building the Desktop Application:**
   - Open the solution file from the `Desktop` folder in Visual Studio.
   - Restore any necessary NuGet packages.
   - Build the solution to compile the application.

3. **Running the Application:**
   - Launch the application from Visual Studio.
   - Log in using the appropriate credentials. Based on your role (Administrator, Instructor, or Student), you will access the corresponding set of functionalities.
