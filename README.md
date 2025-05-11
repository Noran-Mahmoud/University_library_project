# University Library Management System

A comprehensive Windows Forms application for managing a university library system. This application provides an efficient way to manage books, users, and library operations with separate interfaces for administrators and students.

## Features

### User Management
- User registration and login system
- Separate interfaces for administrators and students
- User profile management
- Secure authentication system

### Book Management
- Add new books to the library
- Edit existing book information
- Search and browse books
- Track book availability

### Administrative Features
- Manage user accounts
- Monitor library operations
- Edit book records
- Administrative dashboard

### Student Features
- Browse available books
- View book details
- User profile management
- Student-specific dashboard

## Technical Details

### Built With
- C# (.NET Framework)
- Windows Forms
- SQL Server Database
- Visual Studio

### Project Structure
- `Login_Form.cs` - User authentication interface
- `SignUp_Form.cs` - New user registration
- `Admin_Form.cs` - Administrative dashboard
- `Student_Form.cs` - Student interface
- `AddBook_Form.cs` - Book addition interface
- `EditBook_Form.cs` - Book editing interface
- `EditUser_Form.cs` - User management interface
- `Menu_Form.cs` - Main navigation menu
- `University_LibraryDataSet` - Database schema and data access

## Getting Started

### Prerequisites
- Visual Studio 2019 or later
- .NET Framework
- SQL Server

### Installation
1. Clone the repository
   ```bash
   git clone https://github.com/yourusername/university-library.git
   ```
2. Open the solution file `University_Library.sln` in Visual Studio
3. Restore NuGet packages if prompted
4. Build the solution
5. Run the application

### Database Setup
1. Ensure SQL Server is installed and running
2. The application will use the connection string specified in `App.config`
3. The database schema is defined in `University_LibraryDataSet.xsd`

## Usage

1. Launch the application
2. Login with existing credentials or create a new account
3. Based on user role (Admin/Student), appropriate interface will be displayed
4. Navigate through the menu to access different features

## Contributing

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License - see the LICENSE file for details

## Acknowledgments

- University Library Management System Team
- All contributors who have helped in the development of this project 
