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
  - can be inherited
  - can be overloaded using different ways:
    - By using different type of arguments
    - By using different number of arguments
    - By using different order of arguments
```C#
class Classes : ClassesBase {
    //1st constructor 
    public Classes(string constructorParam) : base(constructorParam){}
    
    //2nd constructor 
    public Classes(double num, string constructorParam) : base(constructorParam){}
    
    //3rd constructor 
    public Classes(string constructorParam, int num) : base(constructorParam){}
}

class ClassesBase {
    //1st constructor base class 
    public ClassesBase(string constructorParam){}
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

## INHERITANCE
It is the mechanism in C# by which one class is allowed to inherit the features(properties and methods) of another class.
- Base Class (also known as super or parent)
- Derived Class (also known as sub, extended or child)
- Inheritance supports the concept of “reusability”, reuse the properties and methods of the existing class.
- C# does not support multiple inheritance (only using interfaces)
- Inheritance Types:
  - Single Inheritance: Class B inheritance from Class A
```C#
   class B : A {
   }
   
   class A { 
   }
```
   - Multilevel Inheritance: Class C inheritance from Class B and this inheritance from Class A
```C#
   class C : B {
   }
   
   class B : A {
   }
   
   class A { 
   }
```
   - Hierarchical Inheritance: Class B inheritance from Class A, Class C inheritance from Class A
```C#
   class C : A {
   }
   
   class B : A {
   }
   
   class A { 
   }
```
   - Multiple Inheritance(Through Interfaces): Class B inheritance from Class A and interface IA
```C#
   class B : A, IA {
   }
   
   interface IA {
   }
   
   class A { 
   }
```
## POLYMORPHISM
The polymorphism is often expressed as 'one interface, multiple functions'.
- static: In static polymorphism, the response to a function is determined at the compile time.
  The mechanism of linking a function with an object during compile time is called early binding. It is also called static binding. 
  - Function Overloading:
    - You can have multiple definitions for the same function name in the same scope. 
    - The definition of the function must differ from each other by the types and/or the number of arguments in the argument list. 
    - You cannot overload function declarations that differ only by return type.
```C#
   class A { 
       void print(int i) {
           Console.WriteLine("Printing int: {0}", i);
       }
       void print(int i, float j) {
            Console.WriteLine("Printing int: {0}, float {1}", i, j);
       }
       void print(string m) {
          Console.WriteLine("Printing string: {0}", m);
       }
   }
```
   - Operator overloading:
      - You can redefine or overload most of the built-in operators available in C#.
      - Thus a programmer can use operators with user-defined types as well.
```C#
   class DynamicPolymorphism
    {
        private double length;  
        private double height; 

        public double getVolume()
        {
            return length * height;
        }
        public void setLength(double l)
        {
            length = l;
        }
        public void setHeight(double h)
        {
            height = h;
        }

        public override string ToString()
        {
            return String.Format("length:{0}, height:{1}", length, height);
        }

        public static DynamicPolymorphism operator+ (DynamicPolymorphism a, DynamicPolymorphism b)
        {
            DynamicPolymorphism dynamicPolymorphism = new DynamicPolymorphism();
            dynamicPolymorphism.length = a.length + b.length;
            dynamicPolymorphism.height = a.height + b.height;
            return dynamicPolymorphism;
        }
    }
```
- dynamic: In dynamic polymorphism, it is decided at run-time.
  - abstract classes:
    - Can not create an instance of an abstract class
    - Can not declare an abstract method outside an abstract class
    - When a class is declared sealed, it cannot be inherited, abstract classes cannot be declared sealed.
```C#
class DynamicPolymorphism1 : AbstractShape
    {
        private int length;
        private int width;

        public DynamicPolymorphism1(int l, int w)
        {
            length = l;
            width = w;
        }

        public override int AbstractArea()
        {
            return (length * width);
        }
    }

    abstract class AbstractShape
    {
        public abstract int AbstractArea();
    }
```
 - dynamic:
   - virtual functions:
     - The "virtual" keyword is used to modify a method, property, indexer, or event declared in the base class and allow it to be overridden in the derived class.
     - The "override" keyword is used to extend or modify a virtual/abstract method, property, indexer, or event of base class into derived class.
     - The "new" keyword is used to hide a method, property, indexer, or event of base class into derived class.
```C#
     class DynamicPolymorphism2 
     {
        public void CallArea(Shape sh)
        {
            int a;
            a = sh.VirtualArea();
            Console.WriteLine("VirtualArea: {0}", a);
        }
    }

    class Rectangle : Shape
    {
        public Rectangle(int a = 0, int b = 0) : base(a, b)
        {

        }
        public new virtual int VirtualArea()
        {
            Console.WriteLine("Rectangle class VirtualArea :");
            return (width * height);
        }
    }
    class Triangle : Shape
    {
        public Triangle(int a = 0, int b = 0) : base(a, b)
        {
        }
        public override int VirtualArea()
        {
            Console.WriteLine("Triangle class VirtualArea :");
            return (width * height / 2);
        }
    }
    class Shape
    {
        protected int width, height;

        public Shape(int a = 0, int b = 0)
        {
            width = a;
            height = b;
        }
        public virtual int VirtualArea()
        {
            Console.WriteLine("Parent class VirtualArea:");
            return 0;
        }
    }
```
## INTERFACE
An interface is defined as a syntactical contract that all the classes inheriting the interface should follow. 
The interface defines the 'what' part of the syntactical contract and the deriving classes define the 'how' part of the syntactical contract.
 - Interfaces are declared using the interface keyword. It is similar to class declaration. 
 - Interface statements are public by default. 
```C#
   class ExampleInterface : IExampleInterface
    {
        private int height;
        private int width;
        private int myProjection;

        public ExampleInterface(int h, int w, int p)
        {
            height = h;
            width = w;
            myProjection = p;
        }

        public int projection
        {
            get => myProjection;
            set => myProjection = value;
        }

        public int GetArea()
        {
            return (height * width + projection);
        }

        public void ShowArea()
        {
            Console.WriteLine("GetArea: {0}", GetArea());
        }
    }

    interface IExampleInterface
    {
        int projection { get; set; }
        int GetArea();
        void ShowArea();
    }
```
 ## ATTRIBUTES
 In c#, Property is an extension of class variable and it provides a mechanism to read, write or change the value of class variable without effecting the external way of accessing it in our applications.
 Accessors: we can change the internal implementation of class variables and expose it without effecting the external way of accessing it based on our requirements.
 - Read-Write:	A property which contains a both get and set accessors.
 - Read-Only:	A property which contains only get accessor.
 - Write-Only:	A property which contains only set accessor.
 ```C#
    class Property
    {
        //C# standar
        private int myVar;
        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        //C# using Expression Bodied
        private int myProjection;
        public int projection
        {
            get => myProjection;           // C# version 6.0+ 
            set => myProjection = value;   // C# version 7.0+ 
        }
    }
 ```
