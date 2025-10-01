# 🍔 Design Patterns in CSharp – Burger Builder

## Welcome!

This project is a simple demonstration of the **Builder Design Pattern** in C#.  
It shows how to create a customizable `Burger` object step by step using a fluent interface.

## What’s Included

The project includes the following components:

- **Burger.cs** – Defines the `Burger` class with bread, meat, cheese, sauces, and extras.  
- **BurgerBuilder.cs** – Implements the **Builder Pattern** for constructing burgers.  
- **Program.cs** – Example usage of the `BurgerBuilder` to create and print a burger.  

## Concepts Demonstrated

- **Builder Pattern** – Encapsulates the construction process of a complex object.  
- **Fluent Interface** – Enables method chaining for clean and readable code.  
- **Object-Oriented Programming** – Classes, properties, and encapsulation.  
- **Override of `ToString()`** – Provides a readable string representation of the burger.  

## Development Environment

- Language: **C#**  
- Type: **.NET Console Application**  
- IDE: **Microsoft Visual Studio** (or any C# compatible editor)  

## Example Usage

```csharp
var burger = new BurgerBuilder()
    .WithBread("Classic")
    .WithMeat("Chicken")
    .WithCheese("Cheddar")
    .AddSauce("Mayo")
    .AddSauce("BBQ")
    .AddExtra("Fries")
    .Build();

Console.WriteLine(burger);
