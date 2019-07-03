## Menu Creator

A Simple menu creator on top of .NET Core 2.2. This application represents a coding exsersise I was given and expected to complete in 60 minutes.

Run Online: https://dotnetfiddle.net/eF3i6x

### Requirements

You must create all of the classes you think are required to complete the below tasks. Comment and style your code as you would normally.

#### Create a Hierarchical Menu

Create a console application which creates a hierarchical data structure containing a number of objects to represent a menu tree. It should be able to support creating a menu N levels deep.

Use the example menu below to populate your data structure:

- Administration
	- User Admin
		- Create User
		- Edit User
	- Product Admin
		- All Products
			- My Products
		- Create Product
	- Order Admin
		- Order Reports
			- Audit Reports
				- Updated Orders
				- Created Orders
		- Create Order
- Reports
	- Win Tech Report
	- Microsoft Report

You do not need to implement the actual menu functionality (e.g. you do not need to write code to execute a menu item or like creating a user).

#### Display a Hierarchical Menu

Using the data structure you created, output the example menu into the console window formatted to correctly show the menu hierarchy.

## Running Locally

### Requirements
- .NET Core 2.2 (https://dotnet.microsoft.com/download/dotnet-core/2.2)

In PowerShell or Bash

1. Clone the repository:

    ```git clone https://github.com/The-Running-Dev/Demo-MenuCreator```

2. Run the application:

    ```dotnet run```

## Project Structure and Rational

### MenuCreator
The console application that creates the menu.

### MenuCreator.Library
The models and logic for storing the menu data and creating the menu.

### MenuCreator.Tests
Work in progress...

#### Technologies
* .NET Core 2.2 (https://dotnet.microsoft.com/)
