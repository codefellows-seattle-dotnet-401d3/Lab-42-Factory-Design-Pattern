# Lab42-Factory Method Design Pattern
A console app intended to give us practice with the factory design pattern.

## Requirments
Create a new Console Application within Visual Studio 2017.
Create a program that uses the Factory Method Design Pattern
This program should consist of a document/resume creation factory.
You are creating types of Documents that make up a Resume or Report, that conists of different Pages such as Cover Letter, References, Work History, Summary Page etc...
Identify the following. In your readme
Product --
Concrete Product (Concrete classes of the product) -
Creator --
Concrete Creator (concrete objects from the creator) -
In your Program.cs file should clearly show through Console.WriteLines() that your program is functioning as requried.

## Product
Abstract 
- page
Concrete
- Project page
- Work Page
- Skill Page

## Creator
Abstract 
- Document
Concreate 
- Resume factory