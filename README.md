
# To Do APP

A Todo application is just a list of things you have to-do. That means basically anything and everything can be on your to-do list—but just because you've written your to-dos down doesn't mean your to-do list is actually useful. Effectively tracking when your work is due can help you prioritize and get great work done


## Prerequirements

* Visual Studio 2022
* MSSQL Server

## Installation

  Clone the Project

      git clone https://github.com/geektechie/todo-app-core.git
  

## How To Run

* Go to todo-app-core folder
* Open solution in Visual Studio 2022
* Set .Web project as Startup Project and build the project.
* Run the application.

## Installation for Nuget Package

* Open the ToDoApp.sln solution file with Visual Studio 2022.
* In Visual Studio, open the Package Manager Console from the Tools menu -> Nuget Package Manager -> Manage Nuget Packages for solution
* Install below packeages
      
      Microsoft.EntityFrameworkCore(8.0.5)
      Microsoft.EntityFrameworkCore.Tools(8.0.5)
      Microsoft.EntityFrameworkCore.SqlServer(8.0.5)


## Connect to the database

* Open the ToDoApp.sln solution file with Visual Studio 2022.
* Using the SQL Server Server name, user and password you created preceding, modify your   connection string in the appsettings.json file:
     
      "ConnectionStrings": {
      "DefaultConnection": "Data Source=[Servername];Initial Catalog=[Database name];uid=[username];Password=[password];Integrated Security=True;MultipleActiveResultSets=true;TrustServerCertificate=True       
      }
* In Visual Studio, open the Package Manager Console from the Tools menu -> Nuget Package Manager -> Package Manager Console. Enter the following command:

      PM> update-database

* This creates the schema and seeds the database with data automatically using Entity Framework and the Entity\Notes.cs class.


## Screenshots

![successOutput](ToDoAPP/Images/1.png?raw=true "Success Output")

![successOutput](ToDoAPP/Images/2.png?raw=true "Success Output")

![successOutput](ToDoAPP/Images/3.png?raw=true "Success Output")

![successOutput](ToDoAPP/Images/4.png?raw=true "Success Output")

![successOutput](ToDoAPP/Images/5.png?raw=true "Success Output")

![successOutput](ToDoAPP/Images/6.png?raw=true "Success Output")


## Features

* Display list of todo items
* Add new todo item with description
* Update the todo item
* Delete the todo item



