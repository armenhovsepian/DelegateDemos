# Delegate in use
A delegate is an object that holds the method(s) reference or is a method(s) pointer.
Delegates are type-safe, secure, and object-oriented.
Delegates are reference type.
***Delegate follows the observer pattern.***

## Different ways to initiate delegates 
1. Named methods
2. Lambda expressions
3. Anonymous methods


## There are 3 types of delegates in .NET
1. Action
2. Func
3. Predicate

## Action
Action points to a method(s) that return void.
```
Action <TParams>
```

## Func
Func points to a method(s) that return a value.
```
Func<TParams, TResult>
```

## Predicate
Predicate points to a method(s) that return a Boolean value.
```
Func<TParams, bool>
```

### Besides the built in .NET delegates, we are able to create our custom delegates.
4. Delegate
5. Event Delegate

## Delegate
We can define our custom delegate by using the *delegate* keyword.
Delegate definition convention is like abstract method definition convention, but instead of abstract use delegate.
```csharp
public delegate return_Type Delegate_Name([parameters]);
```

## Event Delegate
Since delegate knows how to call a method we can use it to define callback methods and implement event handling.
```csharp
public delegate void Delegate_Name();
public event Delegate_Name Event_Name;
```

## Multicast Delegates
A multicast delegate represents a delegate that can invoke more than one method at once. All delegate types have multicast capability. Remember:
* The methods are called in the order they are added.
* If either of the methods throws an exception, the delegate call immediately stops, and no other methods in the list are called. 
* If the delegate returns a value, only the value of the last invoked method will be returned.

## Expression
LINQ To SQL uses lambda expressions to create expresion tree in order to convert C# codes to SQL query

[Delegate in use](http://armenhovsep.com/Blogs/delegate-in-use/)

