# Type Conversions

Beginner level task for practicing implicit/explicit reference conversions and boxing/unboxing conversions.

Estimated time to complete the task - 0.5h.

The task requires .NET 6 SDK installed.


## Task Description

The purpose of this task is to help you better understand the concept following type conversions:    
- implicit and explicit reference conversions;   
- boxing and unboxing conversions.

### Boxing conversions

- Open the [Point.cs](TypeConversions/TypesForConversions/Point.cs) file and inspect the code of the [Point](TypeConversions/TypesForConversions/Point.cs#L3) structure.
- Open the [Color.cs](TypeConversions/TypesForConversions/Color.cs) file and inspect the code of the [Color](TypeConversions/TypesForConversions/Color.cs#L3) enumerator.
- Open the [BoxingConversions.cs](TypeConversions/BoxingConversions.cs) file and implement all methods of the [BoxingConversions](TypeConversions/BoxingConversions.cs#L6) class using the information of the XML-comments.

### Unboxing conversions 

- Open the [Point.cs](TypeConversions/TypesForConversions/Point.cs) file and inspect the code of the [Point](TypeConversions/TypesForConversions/Point.cs#L3) structure.
- Open the [Color.cs](TypeConversions/TypesForConversions/Color.cs) file and inspect the code of the [Color](TypeConversions/TypesForConversions/Color.cs#L3) enumerator.
- Open the [UnboxingConversions.cs](TypeConversions/UnboxingConversions.cs) file and implement all methods of the [UnboxingConversions](TypeConversions/UnboxingConversions.cs#L6) class by using 
    - [cast expression](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast#cast-expression)
    - [as operator](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast#as-operator)
    - [pattern matching](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast#is-operator)   
    For more detailed information use the XML-comments.

### Implicit Reference Conversions

- Open the [Shape.cs](TypeConversions/TypesForConversions/Shape.cs) file and inspect the code of the [Shape](TypeConversions/TypesForConversions/Point.cs#L3) class.
- Open the [Circle.cs](TypeConversions/TypesForConversions/Circle.cs) file and inspect the code of the [Circle](TypeConversions/TypesForConversions/Circle.cs#L5) class.
- Open the [Square.cs](TypeConversions/TypesForConversions/Square.cs) file and inspect the code of the [Square](TypeConversions/TypesForConversions/Square.cs#L5) enumerator.
- Open the [IColorable.cs](TypeConversions/TypesForConversions/IColorable.cs) file and inspect the code of the [IColorable](TypeConversions/TypesForConversions/IColorable.cs#L3) interface.
- Open the [Color.cs](TypeConversions/TypesForConversions/Color.cs) file and inspect the code of the [Color](TypeConversions/TypesForConversions/Color.cs#L3) enumerator.
- Open the [ImplicitReferenceConversions.cs](TypeConversions/ImplicitReferenceConversions.cs) file and implement all methods of the [ImplicitReferenceConversions](TypeConversions/ImplicitReferenceConversions.cs#L6) class using the information of the XML-comments.

### Explicit Reference Conversions

- Open the [Shape.cs](TypeConversions/TypesForConversions/Shape.cs) file and inspect the code of the [Shape](TypeConversions/TypesForConversions/Point.cs#L3) class.
- Open the [Circle.cs](TypeConversions/TypesForConversions/Circle.cs) file and inspect the code of the [Circle](TypeConversions/TypesForConversions/Circle.cs#L5) class.
- Open the [Square.cs](TypeConversions/TypesForConversions/Square.cs) file and inspect the code of the [Square](TypeConversions/TypesForConversions/Square.cs#L5) enumerator.
- Open the [IColorable.cs](TypeConversions/TypesForConversions/IColorable.cs) file and inspect the code of the [IColorable](TypeConversions/TypesForConversions/IColorable.cs#L3) interface.
- Open the [Color.cs](TypeConversions/TypesForConversions/Color.cs) file and inspect the code of the [Color](TypeConversions/TypesForConversions/Color.cs#L3) enumerator.
- Open the [ExplicitReferenceConversions.cs](TypeConversions/ExplicitReferenceConversions.cs) file and implement all methods of the [ExplicitReferenceConversions](TypeConversions/ExplicitReferenceConversions.cs#L6) class by using 
    - [cast expression](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast#cast-expression)
    - [as operator](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast#as-operator)
    - [pattern matching](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast#is-operator)   
    For more detailed information use the XML-comments.

## Fix Compiler Issues

Additional style and code checks are enabled for the projects in this solution to help you maintaining consistency of the project source code and avoiding silly mistakes. [Review the Error List](https://learn.microsoft.com/en-us/visualstudio/ide/find-and-fix-code-errors#review-the-error-list) in Visual Studio to see all compiler warnings and errors.

If a compiler error or warning message is not clear, [review errors details](https://learn.microsoft.com/en-us/visualstudio/ide/find-and-fix-code-errors#review-errors-in-detail) or google for the error or warning code to get more information about the issue.


## Task Checklist

1. Rebuild the solution.
1. Fix all compiler warnings and errors.
1. Run all unit tests, make sure all unit tests completed successfully.
1. Review all changes, make sure the only code files (.cs) in Integers project have changes. No changes in project files (.csproj) or in Integers.Tests project.
1. Stage your changes, and create a commit.
1. Push your changes to remote repository.

## See also

* C# Language Reference
  * [Integral numeric types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types)
  * [return](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/jump-statements#the-return-statement)
  * [throw](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/throw)
* C# Programming Guide
  * [Constants](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constants)
* .NET API
  * [Int16 Struct](https://learn.microsoft.com/en-us/dotnet/api/system.int16)
  * [Int32 Struct](https://learn.microsoft.com/en-us/dotnet/api/system.int32)
  * [UInt32 Struct](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)
  * [Int64 Struct](https://learn.microsoft.com/en-us/dotnet/api/system.int64)
  * [UInt64 Struct](https://learn.microsoft.com/en-us/dotnet/api/system.uint64)
