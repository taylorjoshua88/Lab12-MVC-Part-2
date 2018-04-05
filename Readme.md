# Movie Library

**Author**: Joshua Taylor
**Version**: 1.0.0

## Overview

Movie Library demonstrates basic ASP.NET Core 2.0 MVC, Razor Views, and
creating SQL database connections through Visual Studio's scaffolding features
and DbContext. A simple interface for performing create, read, update, and
delete (CRUD) operations on a database-backed collection of movies is the
primary experience on the site in addition to an about page and contact
information.

The main page for this web application can be accessed by pointing directly to 
the server (the Home controller's Index action redirects to the Movies
controller's Index action) or clicking the "Movie Library" link in the
navigation bar.

## Getting Started

Movie Library targets the .NET Core 2.0 platform, ASP.NET Core, Entity
Framework Core and the MVC Framework. The .NET Core 2.0 SDK can be downloaded 
from the following URL for Windows, Linux, and macOS:

https://www.microsoft.com/net/download/

Additionally, the Entity Framework tools will need to be installed via the
NuGet Package Manager Console in order to create a migration for the local,
development database (run from the solution root):

    Install-Package Microsoft.EntityFrameworkCore.Tools
	Add-Migration Initial
	Update-Database

The dotnet CLI utility would then be used to build and run the application:

    cd MovieLibrary
    dotnet build
    dotnet run

The _dotnet run_ command will start an HTTP server on localhost using Kestrel
which can be accessed by the user's browser pointing to localhost on the port
provided by _dotnet run_'s console output.

Additionally, users can build and run Movie Library using Visual Studio
2017 or greater by opening the solution file at the root of this repository.
All dependencies are referenced via NuGet and should be brought in during
the restore process. If this does not occur, the following will download all
needed dependencies (other than the Entity Framework tools):

    dotnet restore

## Example

#### Index View of Movie Library ####
![Index View Screenshot](/assets/index.JPG)
#### Movie Details View ####
![Movie Details Screenshot](/assets/details.JPG)
#### Edit Movie View ####
![Edit Movie Screenshot](/assets/edit.JPG)
#### Delete Movie View ####
![Delete Movie Screenshot](/assets/delete.JPG)
#### Context Specific Navigation Bar ####
![Navigation Bar Screenshot](/assets/navbar.JPG)
#### Scalable Content and Navigation ####
![Scalable Components Screenshot](/assets/scalable.JPG)

## Architecture

Movie Library uses two controllers: _HomeController_, and _MoviesController_.

### HomeController

_HomeController_ provides actions for displaying static information to the
user in the form of an _About_ action and a _Contact_ action. The _Index_
action is set to simply redirect the user to the _Index_ action of the
_MoviesController_.

### MoviesController

_MoviesController_ delivers the primary user experience for the Movie Library
application. Actions have been defined for CRUD operations on the movies
within the library in the form of _Create_, _Details_, _Edit_, and _Delete_
(respectively). The _Index_ action delivers a simple overview of the movie
library and provides links to the other actions available on this controller.

### Data Model (Movie)

The data model consists of a single table, _Movie_, which is represented in
code by the _Movie_ class. _Movie_ contains an integer-based primary key ID,
a release date, genre, price, and MPAA content rating. Movie Library was
implemented using code-first migrations and uses attribute-based validation
tags on the C# side.

### Frontend

All frontend code has been developed using Bootstrap and JQuery. Some
modifications were made to the default Bootstrap CSS styling provided by
Visual Studio. A shared layout is used for the header and footer of the page
which brings in the rendered Razor View content for the user's currently
used action.

## Change Log

* 4.4.2018 [Joshua Taylor](mailto:taylor.joshua88@gmail.com) - Initial
release.
