# CoreApi
This is a simple user management API implemented in C# using ASP.NET Core. It provides basic CRUD (Create, Read, Update, Delete) operations for managing user data.

## Table of Contents

- [Features](#features)
-  [Technology and Explaination](#technology)
- [Getting Started](#getting-started)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [Running the Application](#running-the-application)
- [Endpoints](#endpoints)
## Features

- Retrieve a list of users
- Retrieve a user by ID
- Insert a new user
- Update user data
- Delete a user

## Technology & Explaination

- .Net core api, entity framework,Mssql server 2019.
- Model validation
- Swagger used for view and test purpose.
- used Exception handling in Usercontroller.
- Created Interface IUser for insert, update,getlist, delete methods.
- added interface into middleware and injected interface into Usercontroller constructor method.
- Used attribute route in UserController
- Created Userrepository to bind data between model and database.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/your-username/your-repository.git
   
2.Navigate to the project directory:

bash:
cd UserApi

3.Restore dependencies:
bash:
dotnet restore

--Usage--

Running the Application
To run the application, use the following command:

bash:
dotnet run
The API will be accessible at http://localhost:5000 by default.
Swagger will gives views api get,post,put,delete methods.
using swagger you can test below methods.


Endpoints
GET /api/User/GetUserList: Retrieve a list of users.
GET /api/User/GetUserListById/{ID}: Retrieve a user by ID.
POST /api/User/InsertUser: Insert a new user.
PUT /api/User/UpdateUser: Update user data.
DELETE /api/User/DeleteUser/{ID}: Delete a user by ID.


Example of Usage:
GET http://localhost:5000/api/User/GetUserList
GET http://localhost:5000/api/User/GetUserListById/{ID}
POST http://localhost:5000/api/User/InsertUser
PUT http://localhost:5000/api/User/UpdateUser
DELETE http://localhost:5000/api/User/DeleteUser/{ID}

Contributing
Contributions are welcome! If you find any issues or have suggestions for improvement, feel free to open an issue or create a pull request.

Adjust the URLs, paths, and other details according to your project structure and preferences. Include any additional information that might be relevant to users and contributors.
