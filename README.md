# Interfaces
An introduction to interfaces in C#

### What Is an Interface?
An interface in C# is like a contract that defines a set of methods (and sometimes properties, events, or indexers) that a class or struct must implement. Think of it as a blueprint that enforces certain capabilities, without caring about how those capabilities are carried out internally.

### Key Points About Interfaces
No Implementation Details
An interface only declares the names and signatures (return types and parameters) of its members (e.g., methods, properties). It does not contain the actual code body or logic.

### Implementation Required
A class or struct that “implements” an interface must write out the method bodies (the actual code) for every member defined in that interface.

### Multiple Interfaces
In C#, a class can implement multiple interfaces. This is in contrast to classes, where C# only supports single inheritance of classes (one class can only inherit from one other class). Interfaces give you more flexibility in structuring your code.

### Polymorphism
Interfaces enable polymorphism. If multiple classes implement the same interface, you can refer to objects of those classes by the interface type and call the methods defined by that interface.

## Why Use Interfaces?
* **Enforce a Contract**: Interfaces ensure any class that implements them will provide the required methods or properties. This is helpful for standardizing how certain features behave across different classes.
* **Loose Coupling**: By programming against interfaces rather than concrete classes, you reduce dependencies. This makes your code more flexible and easier to maintain.
* **Testability**: Using interfaces makes it simpler to create mock or fake implementations when writing unit tests.
* **Separation of Concerns**: Interfaces help separate what something does (the contract) from how it does it (the implementation details).
