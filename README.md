# Project Setup and Execution

This project utilizes .NET 8 for the backend and React.js 18 for the frontend. Follow the instructions below to set up and run the application.

## Prerequisites

- .NET 8 SDK installed
- Node.js and npm installed
- Ensure `.NET` is added to the system environment PATH:
  - `C:\Program Files\dotnet`

## Running the Application

### Running Frontend

1. Navigate to the frontend directory:
   ```bash
   cd frontend/my-app
   ```
2. Start the development server:
   ```bash
   npm run dev
   ```

### Running Backend

1. Navigate to the backend directory:
   ```bash
   cd API
   ```
2. Run the backend server:
   ```bash
   dotnet run --project .\API.csproj
   ```

### Running Both Frontend and Backend Simultaneously

- Execute the batch file ```start.bat``` provided in the project root by double-clicking it. This will start both the frontend and backend servers.

## Building the Application

### Build Backend

1. Navigate to the backend directory:
   ```bash
   cd API
   ```
2. Build the backend:
   ```bash
   dotnet build
   ```

### Build Frontend

1. Navigate to the frontend directory:
   ```bash
   cd frontend/my-app
   ```
2. Build the frontend:
   ```bash
   npm run build
   ```

## Additional Notes

- Ensure all dependencies are installed by running `npm install` in the frontend directory before starting the frontend server.
- If you encounter any issues, verify that `.NET` and `Node.js` are correctly installed and accessible via the command line.