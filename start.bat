@echo off
setlocal

:: Get the current directory where the batch file is located
cd /d "%~dp0"

:: Ensure dotnet.exe is accessible
set PATH=%PATH%;"C:\Program Files\dotnet"

:: Start the backend (build first, then run on HTTPS)
echo Building backend...
cd backend\API
start cmd /k ""C:\Program Files\dotnet\dotnet.exe" build API.csproj && "C:\Program Files\dotnet\dotnet.exe" run --project API.csproj --urls "https://localhost:7210""

:: Wait a few seconds before starting the frontend
ping -n 6 127.0.0.1 >nul

:: Start the frontend
echo Starting frontend...
cd /d "%~dp0frontend\my-app"
start cmd /k "npm run dev"

echo Both backend and frontend started.
pause
