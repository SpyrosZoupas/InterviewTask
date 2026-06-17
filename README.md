## Task Overview

You will be working with a Fines Management system that consists of a .NET API backend and a React frontend. Your goal is to implement filtering functionality across both layers. The backend uses an in-memory database with some test data included.

You may use AI tools such as Copilot, however you will be expected to fully understand and explain your changes.

This task is expected to take around 2 hours, however you may take as long as you like.

### Requirements

1. **Use Template and Clone**
   - Use this repository template to create a new public repository on your own GitHub account
   - Clone your repository locally to begin working on the task

2. **Implement Changes**
   - Modify the API to return the additional field and support filtering fines
   - Update the front end to display the new column and allow users to filter fines
   - If you have any time remaining, carry out additional improvements or refactoring as you see fit

3. **Submit Your Work**
   - Check in and push your completed solution to your repository
   - Ensure all code is committed and the repository is public (or accessible to reviewers)

## Your Task

Extend and modify the API and front end to include the following:

### Additional Columns

Add the following column to the existing table of fines on the front end:

**Customer Name** - This should contain the `CompanyName` of the customer who received the fine. You will need to join the `Fines` and `Customers` data to retrieve this information.

### Filters

Add filters to the front end for the following fields:

1. **Fine Date** - Date picker
2. **Fine Type** - Drop down / Select
3. **Vehicle Registration** - Free text

The user should be able to apply no filters, one filter, or multiple filters simultaneously. The front end should fetch data from the API and update based on the selected filters.

### Other Considerations

- Ensure proper response structure and status codes from the API
- Consider perfomance and error handling where appropriate
- Ensure tests pass

## Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Node.js](https://nodejs.org/) (v18 or later)
- [Git](https://git-scm.com/)
- Code editor IDE of your choice. What we use in house: ([Visual Studio](https://visualstudio.microsoft.com/vs/) or [VS Code](https://code.visualstudio.com/))

### Running the API/Front End

Each application has a respective README.md file, Please see the Fines.Api and Fines.Client folders.

## Technologies Used

### Backend

- **[ASP.NET Core 8.0](https://learn.microsoft.com/en-us/aspnet/core/?view=aspnetcore-8.0)** - Web API framework
- **[Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)** - ORM and data access
- **[In-Memory Database](https://learn.microsoft.com/en-us/ef/core/providers/in-memory/)** - For development/testing
- **[Swashbuckle](https://learn.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger)** - API documentation (Swagger)
- **[xUnit](https://xunit.net/)** - Testing framework

### Frontend

- **[Mantine Documentation](https://mantine.dev/)**
- **[Vite Documentation](https://vitejs.dev/)**
- **[React Documentation](https://react.dev/)**

## Submission

Once you've completed the task:

1. Ensure all your changes are committed
2. Push to your repository
3. Ensure your repository is public
4. Share a link to your repository with your contact at Zenith

## Questions?

If you have any questions about the task requirements or encounter issues with the setup, please reach out to your contact at Zenith for clarification.

There is no penalty for asking questions, so please don't hesitate!
