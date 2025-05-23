# Simple .NET Core Application

This is a simple .NET Core application that demonstrates basic CRUD operations without a database. The application includes functionality for listing, adding, and editing items through a web interface.

## Project Structure

- **Controllers**: Contains the logic for handling requests.
  - `HomeController.cs`: Manages the home page.
  - `ListController.cs`: Handles the display of the item list.
  - `AddController.cs`: Manages the addition of new items.
  - `EditController.cs`: Handles the editing of existing items.

- **Models**: Contains the data structures used in the application.
  - `ItemModel.cs`: Represents an item with properties such as Id, Name, and Description.

- **Views**: Contains the Razor views for rendering the UI.
  - `Home/Index.cshtml`: The home page view.
  - `List/Index.cshtml`: The view for displaying the list of items.
  - `Add/Index.cshtml`: The view for the add item form.
  - `Edit/Index.cshtml`: The view for the edit item form.

- **wwwroot**: Contains static files such as CSS, JavaScript, and third-party libraries.
  - `css`: Stylesheets for the application.
  - `js`: JavaScript files for client-side functionality.
  - `lib`: Third-party libraries (e.g., jQuery, Bootstrap).

- **Configuration Files**:
  - `appsettings.json`: Configuration settings for the application.
  - `Program.cs`: The entry point of the application.
  - `Startup.cs`: Configures services and the request pipeline.

## Setup Instructions

1. Clone the repository to your local machine.
2. Open the project in your preferred IDE.
3. Restore the dependencies using the command:
   ```
   dotnet restore
   ```
4. Run the application using the command:
   ```
   dotnet run
   ```
5. Open your web browser and navigate to `http://localhost:5000` to access the application.

## Usage

- Navigate to the home page to see an overview of the application.
- Use the "List" option to view all items.
- Use the "Add" option to create a new item.
- Use the "Edit" option to modify an existing item.

## Troubleshooting

If you encounter issues with certificates, try closing and reopening your IDE.