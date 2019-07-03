## Menu Creator

A Simple menu creator on top of .NET Core 2.2.

Run Online: https://dotnetfiddle.net/eF3i6x

### Requirements

You must create all of the classes you think are required to complete the below tasks. Comment and style your code as you would normally.

Create a Hierarchical Menu

Create a Console Application which creates a hierarchical data structure containing a number of objects to represent a menu tree. It should be able to support creating a menu N levels deep.

Use the example menu below to populate your data structure:

-Administration
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

Display a Hierarchical Menu
Using the data structure you created in Part One, output the example menu into the console window formatted to correctly show the menu hierarchy.


## Running Locally

### Requirements
- .NET Core 2.2 (https://dotnet.microsoft.com/download/dotnet-core/2.2)

In PowerShell or Bash

1. Clone the repository:

    ```git clone https://github.com/The-Running-Dev/```

2. Run the application:

    ```dotnet run ```

## Project Structure and Rational

### PatientViewer.Data
Encapsulates the data models, interfaces and extensions used within ```PatientViewer.Repository```, ```PatientViewer.Service```, ```PatientViewer.Tests``` and ```PatientViewer.Web```. Here you will find the ```Patient``` model.

### PatientViewer.Tests
Encapsulates all tests for ```PatientViewer.Data```, ```PatientViewer.Repository```, ```PatientViewer.Service``` and ```PatientViewer.Web```. Implements test for the ```StringExtensions```, ```PatientRepository```, ```RepositoryCache```, ```PatientService```, and the ```HomeController```, and ```PatientController```. ```NUnit``` is used as the testing framwork, with the help of ```Moq``` for mocking. Test setup is abstracted in the ```TestsBase``` class that acts as the setup for all tests.

#### Technologies
* .NET Core 2.2 (https://dotnet.microsoft.com/) for the MVC/WebAPI application and supprting code
