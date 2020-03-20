# Hair Salon
#### March 20 2020

ASP.NET core MVC application using Entity Framework Core and MySQL for a Hair Salon Manager website. Add new Stylists, and add new Clients for each Stylist. Practice with ASP.NET core MVC, Entity Framework Core, and MySQL.

## Getting Started

Download the .zip file and extract all files into directory of your choice OR clone the repository to a directory. Open project directory in preferred text editor.

### Prerequisites

1. [.NET Framework](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) 
2. Text Editor (Visual Studio Code)

### Installing

1. Clone the repository:
    ```
    git clone https://github.com/jamisoncozart/HairSalon
    ```
2. Change directories into the project working directory:
    ```
    cd HairSalon/HairSalon
    ```
3. Restore all dependencies:
    ```
    dotnet restore
    ```

#### Setup Database

4. Run the following commands in MySQL to setup this project Database
    ```
    CREATE DATABASE `jamison_cozart`;
    USE `jamison_cozart`;
    CREATE TABLE `stylists` (
        `StylistId` int NOT NULL AUTO_INCREMENT,
        `Name` varchar(45) NOT NULL DEFAULT 'Name',
        `Description` varchar(255) NOT NULL DEFAULT 'Description',
        PRIMARY KEY (`StylistId`)
    );
    CREATE TABLE `clients` (
        `ClientId` int NOT NULL AUTO_INCREMENT,
        `Name` varchar(45) NOT NULL DEFAULT 'Client Name',
        `Haircut` varchar(45) NOT NULL DEFAULT 'Haircut',
        `StylistId` int NOT NULL DEFAULT '0',
        PRIMARY KEY (`ClientId`)
    );
    ```
5. Compile and Run code:
    ```
    dotnet build
    dotnet run
    ```
6. Open the locally hosted server in your preferred web browser:
    ```
    start http://localhost:5000
    ```

## Application Design

### Routing Flowchart

![Project Flowchart](https://github.com/jamisoncozart/HairSalon/HairSalon/images/flowchart.jpg "Project Flowchart")

### BDD Specifications

|Behavior|Input|Output|
|:-:|:-:|:-:|
|User visits root route, redirect to Index route of stylists|visits '/'|Redirect to '/stylists'|
|User clicks 'Add stylist' button, redirect to New Stylist form|clicks 'Add stylist'|Redirect to '/stylists/new' and show New Stylist form|
|User clicks 'Submit' on New Stylist form, add new stylist to DB and redirect to Index route of Stylists|clicks 'submit' on New Stylist form|**Create new Stylist in DB**, Redirect to '/stylists'|
|User clicks on a stylist in the Index route of Stylists, show details of that stylist|clicks on 'Murphy' (id = 2)|Redirect to '/stylists/2', show all details of Murphy|
|User clicks 'Add Client' button, redirect to New Client form|clicks 'Add client'|Redirect to '/stylists/{id}/clients/new' and show New Client form|
|User clicks 'Submit' on New Client form, add new client to DB and redirect to Details route of Stylist|clicks 'submit' on New Client form|**Create new Client in DB**, Redirect to '/stylists/{id}'|
|User clicks on a client in the Details route of a specific stylist, show details of that client|clicks on 'Pedro' (id = 4)|Redirec to '/stylists/{id}/clients/4', show all details of Pedro|
|User clicks 'Delete' button on a Stylist in the Index page of Stylists, delete specific stylist and redirect to Index|clicks 'Delete'|**Delete stylist from DB**, redirect to '/stylists'|
|User clicks 'Edit' button on a Stylist in the Details page, Redirect to Edit form for specific Stylist.|clicks 'Edit'|Redirect to '/stylists/{id}/edit', show Stylist Edit form|
|User clicks 'Submit' button on Stylist edit form, Update details of Stylist in DB and redirect to Details of Stylist|clicks 'submit'|**Update Stylist in DB**, redirect to '/stylists/{id}'|


## Technologies Used

* C#
* ASP.NET core MVC 2.2
* Entity Framework Core
* MySQL + MySQL Workbench version 8.0.15
* RESTful Routing
* CRUD Functionality
* Git

## Authors

* **Jamison Cozart** - (https://github.com/jamisoncozart)

## License

Licensed under the MIT license.

&copy; 2020 - Jamison Cozart