# Dotnet-Create-a-new-.NET-project-and-work-with-dependencies
## Add packages to a dotnet application
   use Nuget Package manageer for managing third party packages, libraries. 
### Install a third party Package 
      dotnet add package <name of dependency>  
### After installation use
      dotnet list package
      dotnet list package --include-transitive
### Restore Dependancies
      dotnet restore
### Remove Dependancies
      dotnet remove <name of dependency>
### Listing available sdks  
      dotnet --list-sdks
## Create a sample .net project
### Create a console application using dotnet console
      dotnet new console -f net6.0
### Run the dotnet application 
      dotnet run
### Install a dependancy and using it will be explained in the source
      dotnet add package Humanizer --version 2.7.9
