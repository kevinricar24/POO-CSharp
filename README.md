# C# 
## Object-Oriented Programming Language 

## Structure File
- Namespace declaration
- class
  - Class methods
  - Class attributes
- Main method
- Statements and Expressions
- Comments

## BASIC SYNTAX
- Keywords      : abstract, as, base, bool, etc
- Identifiers   : using C# coding standards
  - Pascal Case: for class names and method names.
  - camel Case: for method arguments and local variables. 

## DATA TYPES
The variables in C#, are categorized into the following types: 
- Value types		   : int, decimal, double, bool, etc 
- Reference types  : object, dynamic, and string.
- Pointer types    : type* identifier

## CONVERSION TYPE
- Implicit type conversion		: ToBoolean, ToByte, ToChar, ToDateTime, etc 
- Explicit type conversion    : cast (int), cast (bool), etc 

## ENCAPSULATION
- Encapsulation is implemented by using access specifiers.
  - Public: Access to all code in the program
  - Private: Access to only members of the same class
    - Note: Properties, Methods, (Classes can be private only if are nested) are private by default.
  - Protected: Access to members of the same class and its derived classes
  - Internal: Access to the current assembly
    - Note: Classes are internal by default.
  - Protected Internal: Access to types derived from containing class and the current assembly.
  - Private Protected: Access to types derived from the containing class, but only within its containing assembly.
    - Note: is valid in C# version 7.2 and later.

## PARAMETERS
Used in the called of the methods.
- Value     : swap(int x, int y)
- Reference : swap(ref int x, ref int y)
- Out       : swap(out int x)

## NULLABLES
Used in the called of the methods.
- Value                     : int? num1 = 45;
- Coalescing Operator (??)  : int num2 = num3 ?? 45;

## STRUCTURES (struct)
Classes and Structures have the following basic differences: 
 - classes are reference types and structs are value types
 - structures do not support inheritance
 - structures cannot have a default constructor
