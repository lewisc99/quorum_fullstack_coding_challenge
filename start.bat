@echo off
setlocal

cd /d "%~dp0"

set PATH=%PATH%;"C:\Program Files\dotnet"

echo Building backend...
cd backend\API
start cmd /k ""C:\Program Files\dotnet\dotnet.exe" build API.csproj && "C:\Program Files\dotnet\dotnet.exe" run --project API.csproj --urls "https://localhost:7210""

echo Starting frontend...
cd /d "%~dp0frontend\my-app"
start cmd /k "npm run dev"

echo Both backend and frontend started.
pause
