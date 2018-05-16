# Lab42 Phil Werner

## Factory Design Pattern
This program shows the Factory Design Pattern using a two seperate Document "Factories".
Within the factory you create different pages that then create a document.

## Tools Used
Microsoft Visual Studio Community Version 15.5.7

C#

ASP.Net

xUnit

## Getting Started

Clone this repository to your local machine.
```
$ git clone https://github.com/philipwerner/Lab-42-Factory-Design-Pattern.git 
```
Once downloaded, cd into the ```Lab-42-Factory-Design-Pattern``` directory.
```
$ cd Lab-42-Factory-Design-Pattern
```
The cd into ```FactoryDesign``` directory.
```
$ cd FactoryDesign
```
The cd into the second ```FactoryDesign``` directory.
```
$ cd FactoryDesign
```
Then run .NET build.
```
$ dotnet build
```
Once that is complete, run the program.
```
$ dotnet run
```

## Structure

###Product: 
The Page class is the product as the whole document is made up of Pages
###Concrete Product (Concrete classes of the product):
####For the Resume Factory:
```CoverLetter```
```Education```
```WorkHistory```
```Volunteer```

####For the TPS Report Factory:
```TimeReport```
```ProgressReport```
```StatusReport```
###Creator: 
The Document class is the creator class
###Concrete Creator (concrete objects from the creator):
```ResumeDocument```
```TPSReport```