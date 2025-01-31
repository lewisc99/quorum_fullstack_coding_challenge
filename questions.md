# Implementation Write-up

## 1. Discuss your strategy and decisions implementing the application.

The complexity of understanding the business logic was relatively easy. However, I needed to modify the CSV headers to work properly with C#.

### Backend:
- The backend was implemented using .NET 8 with C#.
- API versioning was included.
- Swagger was used for API documentation.
- The application follows Domain-Driven Design (DDD) with Clean Architecture to separate concerns and responsibilities.
- CORS was configured to allow access only from the frontend port.
- Generic classes and components were implemented to enhance code reusability.
- Using generics made the code easier to test and refactor.

### Frontend:
- The frontend was built using React.js 18.
- Material-UI was used for the UI components.
- Axios was used for API requests.

## 2. How would you change your solution to account for future columns that might be requested, such as "Bill Voted On Date" or "Co-Sponsors"?

The application was designed with flexibility in mind:
- Entities in the backend were structured similarly to database tables, with DTOs matching their properties.
- Adding new properties would seamlessly integrate with the existing code.
- The frontend only requires updating the interface to handle the new properties, ensuring minimal modifications.

## 3. How would you change your solution if instead of receiving CSVs of data, you were given a list of legislators or bills that you should generate a CSV for?

If the goal is to generate a CSV for frontend downloads:
- I would create new API endpoints to generate and serve CSV files.
- The frontend would include a download button to fetch the generated CSV.

If the goal is to create a list of legislators or bills based on existing entities:
- The repository layer would be modified to seed and retrieve the necessary data.
- A new service would be implemented to generate the CSV based on this data.
- The process of reading and handling CSV files would remain largely unchanged.

## 4. How long did you spend working on the assignment?

I spent approximately **2.5 days** working on this assignment, starting on **January 29, 2025, at 9:35 PM**.

