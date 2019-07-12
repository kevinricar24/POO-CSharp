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
 
 ## CLASSES
 
- Properties
- Methods
- Constructor: 
  - same name of the class
  - can have parameters
  - can be overloaded using different ways:
    - By using different type of arguments
    - By using different number of arguments
    - By using different order of arguments
```C#
class Classes {
    //1st constructor 
    Classes(string constructorParam){}
    
    //2nd constructor 
    Classes(double constructorParam){}
    
    //3rd constructor 
    Classes(string constructorParam, int num){}
}
```
- Destructor: 
  - same name of the class
  - can not have parameters
  - cannot be inherited or overloaded
  - *The object of a class in C# will be destroyed by the garbage collector in any of the following cases
    - Case1: At the end of a program execution each and every object that is associated with the program will be destroyed by the garbage collector.
    - Case2: The Implicit calling of the garbage collector occurs sometime in the middle of the program execution provided the memory is full so that the garbage collector will identify unused objects of the program and destroys them.
    - Case 3: The Explicit calling of the garbage collector can be done in the middle of program execution with the help of “GC.Collect()” statement so that if there are any unused objects associated with the program will be destroyed in the middle of the program execution.
    
```C#
        class Classes {
            ~Classes(string ctorParam){}
        }
```
   *Note: in .NET Core Projects is neccesary call the garbage collector of explicit form (case 3).

```C#
        class Classes {
            ~Classes(){}
        }

        class Program
        {
            static void Main(string[] args)
            {
                Program program = new Program();
                program.DemoClasses();
                GC.Collect();
            }

            public void DemoClasses()
            {
                string ctorParam = "Constructor";
                Classes clasess = new Classes(ctorParam);
                clasess.Display();
            }
       }
```
 
