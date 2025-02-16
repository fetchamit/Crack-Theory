# Interview Questions in Dot NET CORE MVC
----------------------------------------------
## Question: What is means by design pattern in .NET Core?
Ans: Design pattern provides us reusable and structured way to write efficient, scalable, and maintainable code.

## Question: What is loose Coupling?
Ans: In .NET Core, `loose coupling` refers to a design principle where components within an application have minimal dependencies on each other.

## Question: What is Dependecy Injunction in .NET Core?
Answer: In `.NET Core` dependenct injunction is a built-in design pattern. Which increases Loose Coupling. It inject dependencies automatically from outside that can be used in application instead of creating by application.

## What are the services lifetime in .NET Core?
Answer: Services lifetime is specified when a service is registerd by `Dependency Injunction(DI) Container`. It also defines that how long a service instance lives and how it's shared across different components and requests. 
* There are three types of `Services Lifetime `
  * `Singleton`: A service is created only once, and then used throughout the application's lifetime.
  * `Scoped` : A service is created once per client request or connection.
  * `Transient` : A service is created each time it's requested. 

## What is Authentication and Authorization in .NET Core?
Answer: 
* `Authentication`: Authentication means checking a user is valid or not.
  * `Example`- A person which is loging with `UserId` and `Password` checking this user is valid or not is an example `Authentication`.
* `Authorization` : Authorization means that this user is valid and allowed to access the services according to it's role.
  * `Example` - After successfull `Authentication` redirection to User Dashboard is called `Authorization`.

## What is the purpose of the async keyword in .NET?
* The `async` keyword is used to define asynchronous methods in C#. It allows methods to run asynchronously without blocking the main thread. It sends that method to another thread to perform task.

``` csharp
public async Task<string> FetchDataAsync()
{
    await Task.Delay(1000); // Simulates data fetching
    return "Data fetched!";
}
```






















