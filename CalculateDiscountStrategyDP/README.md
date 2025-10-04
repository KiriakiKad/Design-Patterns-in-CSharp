# 💸 Design Patterns in CSharp – Calculate Discount (Strategy Pattern)

## Welcome!

This project is a simple demonstration of the **Strategy Design Pattern** in C#.  
It shows how to apply different discount strategies dynamically at runtime using an interchangeable set of algorithms.

## What’s Included

The project includes the following components:

- **IDiscountStrategy.cs** – Defines the strategy interface with the `Pay(double amount)` method.  
- **NoDiscount.cs** – Implements the strategy that applies **no discount**.  
- **PercentageDiscount.cs** – Implements the strategy that applies a **20% discount**.  
- **FixedDiscount.cs** – Implements the strategy that subtracts a **fixed €5 discount**.  
- **DiscountContext.cs** – Maintains a reference to the current strategy and delegates the `Pay` method.  
- **Program.cs** – Demonstrates switching between discount strategies at runtime.  

## Concepts Demonstrated

- **Strategy Pattern** – Enables selecting different algorithms (discount types) at runtime.  
- **Encapsulation** – Each discount behavior is encapsulated in its own class.  
- **Dependency Injection** – Strategies are passed into the context, promoting flexibility.  
- **Open/Closed Principle (SOLID)** – New discount strategies can be added without modifying existing code.  

## Development Environment

- Language: **C#**  
- Type: **.NET*  
- IDE: **Microsoft Visual Studio** (or any C# compatible editor)  

## Example Usage

```csharp
var productPrice = 103.70;
var context = new DiscountContext(new NoDiscount());

context.Pay(productPrice);              // No discount
context.SetStrategy(new PercentageDiscount());
context.Pay(productPrice);              // 20% discount
context.SetStrategy(new FixedDiscount());
context.Pay(productPrice);              // Fixed 5 euro discount
```

## Output Example

```
No discount for the amount of 103.7 euros
You get a 20% discount. The final price is: 82.96 euros
You get a 5 euro discount. The final price is: 98.7 euros
```

## Summary

This project demonstrates how the **Strategy Pattern** provides flexibility and scalability.  
By defining separate discount strategies, you can easily add or modify pricing logic without changing the core application code.
