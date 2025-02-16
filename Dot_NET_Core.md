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
    // Task which can be performed...
}
```

## What are Events in C#?
* `Events` in C# are a way to notify other parts of the program when something happens. They are based on delegates and are used in the publisher-subscriber model.
* Events are often used to signal user actions like button clicks or menu selections.
* Understanding events and delegates can help you write more flexible, maintainable, and decoupled code.

## What is LINQ in C#?
`LINQ (Language Integrated Query)` is a query syntax in C# used to query data from various sources like collections, databases, and XML documents.
```csharp
int[] numbers = { 1, 2, 3, 4, 5 };
var evenNumbers = numbers.Where(n => n % 2 == 0);
```
## What is a try-catch block in C#?
A `try-catch` block is used for exception handling in C#. It allows you to catch and handle runtime exceptions
``` csharp
try
{
    int a = 10, b = 0;
    int result = a / b; // Will throw DivideByZeroException
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
finally
{
    Console.WriteLine("Execution completed.");
}
```

## What is the difference between abstract class and interface?
* An abstract class can contain abstract methods and non abstract methods both but in interface it can only contain abstract methods.
* An abstract calss can contains Data members but interface can not contains Data members.
* Multiple abstract classes can not be used in inheritance in single class but multiple interfaces can be inherited in a single class.
* An abstract class can inherit an inerface but an interface can not inherit.
* An abstract class can contain constructor but interface can not contain.

```csharp
abstract class Animal
{
    public abstract void Speak();
    public void Sleep()
    {
        Console.WriteLine("Sleeping...");
    }
}

interface IFlyable
{
    void Fly();
}

public class Bird : Animal, IFlyable
{
    public override void Speak()
    {
      Console.WriteLine("Chirp Chirp");
    }
    public void Fly()
    {
      Console.WriteLine("Flying...");
    }
}
```

## What is a delegate?
* Delegate is used to store address(reference) of a function. Delegate is a function pointer.
Delegate can store address of a function that has same signature. So it is necessary to have same signature of delegate and corresponding function. Delegates are generally used to create event handlers(A code to handle events like as click, change, etc).
```csharp

public delegate void Show(string msg);    // delegate initialization
Show s=new Show(test);                    // function initialization into delgate
s(45,32);                                 // function calling by delegate

```

## what is serialization and deserialization in C#?
`Serialization` and `deserialization` are used to convert objects into a format that can be stored or transferred and then rebuild them back into objects.
* Serialization is the process of converting an object into a format `(JSON, XML, binary, etc.)`.
* Deserialization is the process of converting `serialized data (JSON, XML, binary)` back into an object.
``` csharp
// Serialization
Person person = new Person { Name = "Alice", Age = 25 };
string jsonString = JsonSerializer.Serialize(person);
Console.WriteLine(jsonString);      // output : "{\"Name\":\"Alice\",\"Age\":25}"

// Deserialization
string json = "{\"Name\":\"Alice\",\"Age\":25}";
Person personObj = JsonSerializer.Deserialize<Person>(json);
Console.WriteLine($"Name: {personObj.Name}, Age: {personObj.Age}");     // Output : Name: Alice, Age: 25
```
## What is Garbage Collector?
* The `Garbage Collector (GC)` in C# is an automatic memory management system that frees up memory by removing objects that are no longer in use.
* Think of the Garbage Collector as a cleaning robot that automatically finds and deletes unused objects to free up memory.

## What is a sealed class?
Sealed class is a special type of class. It can not be inherited by any class. We can only use that class by creating object.
``` csharp
sealed class Animal  
{
    public void Speak()
    {
        Console.WriteLine("Animal makes a sound");
    }
}
```
## What are boxing and unboxing?
* Boxing is the process of converting a value type (e.g., int, double) into an object type. The value is stored in the heap, making it a reference type.
```csharp
int num = 10;         // Value type (stored in stack)
object obj = num;     // Boxing (value is copied to the heap)

Console.WriteLine(obj);  // Output: 10
```
* Unboxing is the process of extracting a value type from an object. The value is retrieved from the heap and assigned back to a value type variable.
``` csharp
object obj = 10;   // Boxing
int num = (int)obj;  // Unboxing (explicit conversion required)

Console.WriteLine(num);  // Output: 10
```
## What is immediate execution in LINQ?
In LINQ, methods like `ToList(), ToArray(), Count(), First(), etc.` trigger immediate execution. These methods force the query to execute immediately and store the results, instead of waiting for iteration.
``` csharp
List<int> resultList = numbers.Where(n => n > 2).ToList();
``` 
## What is Deferred execution in LINQ?
Deferred execution in LINQ means that a query is not executed immediately when it is defined, but rather only when the query is iterated over (e.g., using foreach).
``` csharp
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

// Deferred Execution: The query is NOT executed yet
var query = numbers.Where(n => n > 2);

numbers.Add(6); // Changing the original list BEFORE execution

// Execution happens here (query is iterated)
foreach (var num in query)
{
   Console.Write(num + " ");  // Output: 3 4 5 6
}
```



















