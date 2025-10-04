# 🧠 Design Patterns in CSharp

## Welcome!

This repository demonstrates three of the most widely used **Object-Oriented Design Patterns** in C#:  
**Builder**, **Strategy**, and **Factory**.  

Each pattern focuses on a different software design goal —  
**object creation**, **behavior flexibility**, and **object instantiation control**.  

These examples show how design patterns help developers write code that is **modular**, **extensible**, and **easy to maintain**.

---

## 🧱 1. Burger Builder – *Builder Pattern*

### 📝 Overview
The **Builder Pattern** separates the construction of a complex object from its representation.  
It allows step-by-step creation of an object by chaining methods (fluent interface).  

In this project, it is used to build a customizable **Burger** with ingredients like bread, meat, cheese, and sauces.

### 📂 Key Files
- **Burger.cs** – Defines the structure of the burger.  
- **BurgerBuilder.cs** – Implements the builder methods.  
- **Program.cs** – Demonstrates how to construct and display a burger.  

### 💡 Why Use the Builder Pattern
✅ Makes object creation **flexible and readable**.  
✅ Simplifies the construction of objects with **many optional parameters**.  
✅ Avoids **long constructors** and improves **code clarity**.  
✅ Allows **reuse of the same construction process** for different representations.

### 🧠 When to Use
- When an object requires **multiple configuration steps**.  
- When the object creation process should be **independent of its representation**.  
- When you want to provide a **fluent interface** for better code readability.

### 💻 Example
```csharp
var burger = new BurgerBuilder()
    .WithBread("Classic")
    .WithMeat("Chicken")
    .WithCheese("Cheddar")
    .AddSauce("BBQ")
    .AddExtra("Fries")
    .Build();

Console.WriteLine(burger);
```

---

## 💸 2. Calculate Discount – *Strategy Pattern*

### 📝 Overview
The **Strategy Pattern** defines a family of algorithms, encapsulates each one, and makes them interchangeable at runtime.  
This allows the behavior of a system to change dynamically **without modifying the code that uses it**.  

Here, it’s used to apply different **discount calculation strategies** such as no discount, percentage discount, or fixed discount.

### 📂 Key Files
- **IDiscountStrategy.cs** – The common strategy interface.  
- **NoDiscount.cs**, **PercentageDiscount.cs**, **FixedDiscount.cs** – Concrete strategies.  
- **DiscountContext.cs** – Selects and applies the chosen strategy.  
- **Program.cs** – Demonstrates changing strategies at runtime.

### 💡 Why Use the Strategy Pattern
✅ Promotes **flexibility** by allowing you to switch behaviors at runtime.  
✅ Encourages **code reuse** and **maintainability** by separating algorithms.  
✅ Makes your system **open for extension but closed for modification** (Open/Closed Principle).  
✅ Reduces **complex conditional logic** (`if/else` or `switch` statements).

### 🧠 When to Use
- When you have **multiple ways to perform an operation**, and you want to choose dynamically.  
- When you need to **eliminate repeated conditional code**.  
- When different algorithms may apply under **different conditions**.

### 💻 Example
```csharp
var price = 103.70;
var context = new DiscountContext(new NoDiscount());

context.Pay(price);
context.SetStrategy(new PercentageDiscount());
context.Pay(price);
context.SetStrategy(new FixedDiscount());
context.Pay(price);
```

### 🖨️ Example Output
```
No discount for the amount of 103.7 euros
You get a 20% discount. The final price is: 82.96 euros
You get a 5 euro discount. The final price is: 98.7 euros
```

---

## 📩 3. Notification System – *Factory Pattern*

### 📝 Overview
The **Factory Pattern** provides an interface for creating objects without exposing the instantiation logic to the client.  
It centralizes object creation and allows you to add new product types with minimal code changes.

In this project, the pattern is used to create different **Notification** types (Email, SMS, Push) based on user input.

### 📂 Key Files
- **INotification.cs** – Interface defining the `Send(string message)` method.  
- **EmailNotification.cs**, **SmsNotification.cs**, **PushNotification.cs** – Concrete classes.  
- **NotificationFactory.cs** – Decides which notification type to create.  
- **Program.cs** – User interface to select and send messages.

### 💡 Why Use the Factory Pattern
✅ **Centralizes object creation** — the client doesn’t need to know class names.  
✅ **Improves maintainability** — adding new types requires minimal changes.  
✅ **Encourages loose coupling** — the client depends only on interfaces, not implementations.  
✅ Makes the system **more scalable and extensible**.

### 🧠 When to Use
- When the creation logic is **complex or repetitive**.  
- When you want to **decouple object creation from its usage**.  
- When you anticipate adding **new types of objects** in the future.

### 💻 Example
```csharp
var factory = new NotificationFactory();

while (true)
{
    Console.Write("Select notification type (email, sms, push) or quit: ");
    var input = Console.ReadLine()?.Trim().ToLower();
    var notification = factory.SendNotification(input);

    if (notification != null)
    {
        Console.Write("Enter message: ");
        var msg = Console.ReadLine();
        notification.Send(msg);
    }
}
```

---

## 🧩 Summary

| Pattern | Type | Purpose | Benefits | Example |
|----------|------|----------|-----------|----------|
| **Builder** | Creational | Builds complex objects step-by-step | Flexible construction, clean code, fluent interface | Burger Builder |
| **Strategy** | Behavioral | Switches algorithms at runtime | Easy to extend, eliminates conditionals, improves flexibility | Discount System |
| **Factory** | Creational | Creates objects without exposing logic | Centralized creation, decoupling, scalability | Notification System |

---

## 🛠️ Development Environment

- Language: **C# (.NET)**  
- Type: **Console Applications**  
- IDE: **Microsoft Visual Studio 2022**  
- Target Framework: **.NET 6 or later**

---

## 💬 Author

**Kiriaki Kad**  
🎓 Educational demonstration of core **Design Patterns** in C# focusing on clean, extensible, and maintainable code.

---

## 🌟 Why Design Patterns Matter

Design Patterns are **proven solutions** to common software design problems.  
They help developers:

- Write **cleaner, more reusable code**  
- Reduce **code duplication and complexity**  
- Make software **easier to extend and maintain**  
- Improve **team communication** using a shared design vocabulary  

---

🧠 *“Design patterns are not about memorizing structures — they’re about recognizing problems and choosing the right solution.”*
