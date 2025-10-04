# 📩 Design Patterns in CSharp – Notification System (Factory Pattern)

## Welcome!

This project is a simple demonstration of the **Factory Design Pattern** in C#.  
It shows how to create different types of notifications (Email, SMS, Push) dynamically at runtime, without tightly coupling the client code to specific classes.

## What’s Included

The project includes the following components:

- **INotification.cs** – Defines the common interface `Send(string message)` for all notification types.  
- **EmailNotification.cs** – Implements the `INotification` interface to simulate sending an **email**.  
- **SmsNotification.cs** – Implements the `INotification` interface to simulate sending an **SMS** message.  
- **PushNotification.cs** – Implements the `INotification` interface to simulate sending a **push notification**.  
- **NotificationFactory.cs** – Implements the **Factory Pattern**, deciding which notification type to create based on user input.  
- **Program.cs** – The entry point that interacts with the user, selects the notification type, and sends messages.  

## Concepts Demonstrated

- **Factory Pattern** – Encapsulates object creation logic and returns instances based on runtime input.  
- **Loose Coupling** – The client code depends only on the `INotification` interface, not the concrete classes.  
- **Polymorphism** – Each notification type implements the same interface but behaves differently.  
- **Extensibility** – Adding a new notification type (e.g., Slack, WhatsApp) requires only a new class and a small factory update.  

## Development Environment

- Language: **C#**  
- Type: **.NET Console Application**  
- IDE: **Microsoft Visual Studio** (or any C# compatible editor)  

## Example Usage

```csharp
var factory = new NotificationFactory();

while (true)
{
    Console.Write("Select the type of message to send (email, sms, push) or quit: ");
    var input = Console.ReadLine()?.Trim().ToLower();

    var notification = factory.SendNotification(input);

    if (notification != null)
    {
        Console.Write("Enter your message: ");
        var message = Console.ReadLine();
        notification.Send(message);
    }
}
```

## Example Output

```
Select the type of message to send (email, sms, push) or quit: email
Enter your message: Hello world!
Sending an Email

Select the type of message to send (email, sms, push) or quit: sms
Enter your message: Hi there!
Sending SMS

Select the type of message to send (email, sms, push) or quit: push
Enter your message: New update available!
Sending a push notification
```

## Summary

This project demonstrates the **Factory Design Pattern** by showing how to delegate object creation to a centralized factory.  
It provides flexibility and scalability, making it easy to introduce new notification methods without modifying core logic.
