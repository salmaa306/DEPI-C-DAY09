#region p1
//using System;

//enum Weekdays
//{
//    Monday = 1,
//    Tuesday,
//    Wednesday,
//    Thursday,
//    Friday
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
//        {
//            Console.WriteLine($"{day} = {(int)day}");
//        }
//    }
//}
#endregion
#region p2
//using System;

//enum Grades : short
//{
//    F = 1,
//    D,
//    C,
//    B,
//    A
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        foreach (Grades grade in Enum.GetValues(typeof(Grades)))
//        {
//            Console.WriteLine($"{grade} = {(short)grade}");
//        }
//    }
//}
#endregion
#region p3
//using System;

//public class Person
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public string Department { get; set; }

//    public Person(int id, string name, string department)
//    {
//        Id = id;
//        Name = name;
//        Department = department;
//    }

//    public void Display()
//    {
//        Console.WriteLine($"Id: {Id}, Name: {Name}, Department: {Department}");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Person p1 = new Person(1, "Alice", "IT");
//        Person p2 = new Person(2, "Bob", "HR");

//        p1.Display();
//        p2.Display();
//    }
//}
#endregion
#region p4
//using System;

//public class Parent
//{
//    public virtual double Salary
//    {
//        get { return 5000; }
//    }
//}

//public class Child : Parent
//{
//    // Sealed override: cannot be overridden further
//    public sealed override double Salary
//    {
//        get { return 8000; }
//    }

//    // Method that uses the sealed Salary property
//    public void DisplaySalary()
//    {
//        Console.WriteLine($"Salary: {Salary}");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Child c = new Child();
//        c.DisplaySalary();
//    }
//}
#endregion
#region p5
//using System;

//public class Utility
//{
//    // Static method to calculate rectangle perimeter
//    public static double CalculateRectanglePerimeter(double length, double width)
//    {
//        return 2 * (length + width);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Call static method without creating an object
//        double perimeter = Utility.CalculateRectanglePerimeter(5, 10);
//        Console.WriteLine($"Rectangle Perimeter: {perimeter}");
//    }
//}
#endregion
#region p6
//using System;

//public class ComplexNumber
//{
//    public double Real { get; set; }
//    public double Imaginary { get; set; }

//    public ComplexNumber(double real, double imaginary)
//    {
//        Real = real;
//        Imaginary = imaginary;
//    }

//    // Overload * operator for complex numbers
//    public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
//    {
//        // (a+bi)*(c+di) = (ac - bd) + (ad + bc)i
//        double realPart = c1.Real * c2.Real - c1.Imaginary * c2.Imaginary;
//        double imaginaryPart = c1.Real * c2.Imaginary + c1.Imaginary * c2.Real;
//        return new ComplexNumber(realPart, imaginaryPart);
//    }

//    public override string ToString()
//    {
//        return $"{Real} + {Imaginary}i";
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        ComplexNumber c1 = new ComplexNumber(2, 3);
//        ComplexNumber c2 = new ComplexNumber(4, 5);

//        ComplexNumber result = c1 * c2;

//        Console.WriteLine($"({c1}) * ({c2}) = {result}");
//    }
//}
#endregion
#region p7
//using System;

//enum GenderByte : byte
//{
//    Male = 1,
//    Female = 2
//}

//enum GenderInt
//{
//    Male = 1,
//    Female = 2
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Enum variables
//        GenderByte gByte = GenderByte.Male;
//        GenderInt gInt = GenderInt.Male;

//        // Print values
//        Console.WriteLine($"GenderByte: {gByte} = {(byte)gByte}");
//        Console.WriteLine($"GenderInt: {gInt} = {(int)gInt}");

//        // Demonstrate memory usage
//        Console.WriteLine($"\nMemory size of GenderByte variable: {sizeof(byte)} byte");
//        Console.WriteLine($"Memory size of GenderInt variable: {sizeof(int)} bytes");
//    }
//}
#endregion
#region p8
//using System;

//public class Utility
//{
//    // Static method to convert temperatures
//    public static double ConvertTemperature(double temp, string fromUnit, string toUnit)
//    {
//        if (fromUnit.ToLower() == "c" && toUnit.ToLower() == "f")
//        {
//            return (temp * 9 / 5) + 32;
//        }
//        else if (fromUnit.ToLower() == "f" && toUnit.ToLower() == "c")
//        {
//            return (temp - 32) * 5 / 9;
//        }
//        else
//        {
//            throw new ArgumentException("Invalid units. Use 'C' for Celsius or 'F' for Fahrenheit.");
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        double celsius = 25;
//        double fahrenheit = Utility.ConvertTemperature(celsius, "C", "F");
//        Console.WriteLine($"{celsius}°C = {fahrenheit}°F");

//        double fTemp = 77;
//        double cTemp = Utility.ConvertTemperature(fTemp, "F", "C");
//        Console.WriteLine($"{fTemp}°F = {cTemp}°C");
//    }
//}
#endregion
#region p9
//using System;

//enum Grades
//{
//    F = 1,
//    D,
//    C,
//    B,
//    A
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Enter a grade (F, D, C, B, A): ");
//        string input = Console.ReadLine();

//        // Try to parse string to Grades enum
//        bool success = Enum.TryParse(input, true, out Grades grade);

//        if (success && Enum.IsDefined(typeof(Grades), grade))
//        {
//            Console.WriteLine($"Parsed successfully! Grade = {grade} ({(int)grade})");
//        }
//        else
//        {
//            Console.WriteLine("Invalid grade entered.");
//        }
//    }
//}
#endregion
#region p10
//using System;

//// Employee class with overridden Equals
//public class Employee
//{
//    public int Id { get; set; }
//    public string Name { get; set; }

//    public Employee(int id, string name)
//    {
//        Id = id;
//        Name = name;
//    }

//    // Override Equals to compare by Id
//    public override bool Equals(object obj)
//    {
//        if (obj is Employee other)
//        {
//            return this.Id == other.Id;
//        }
//        return false;
//    }

//    public override int GetHashCode()
//    {
//        return Id.GetHashCode();
//    }

//    public override string ToString()
//    {
//        return $"Id: {Id}, Name: {Name}";
//    }
//}

//// Generic helper class with SearchArray method
//public static class Helper2<T>
//{
//    public static int SearchArray(T[] array, T item)
//    {
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i].Equals(item))
//            {
//                return i; // Return index if found
//            }
//        }
//        return -1; // Not found
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Employee[] employees = new Employee[]
//        {
//            new Employee(1, "Alice"),
//            new Employee(2, "Bob"),
//            new Employee(3, "Charlie")
//        };

//        // Search for an employee with Id = 2
//        Employee searchEmployee = new Employee(2, "AnyName"); // Name ignored in Equals
//        int index = Helper2<Employee>.SearchArray(employees, searchEmployee);

//        if (index >= 0)
//        {
//            Console.WriteLine($"Employee found at index {index}: {employees[index]}");
//        }
//        else
//        {
//            Console.WriteLine("Employee not found.");
//        }
//    }
//}
#endregion
#region p11
//using System;

//public static class Helper
//{
//    // Generic method to return the greater of two values
//    public static T Max<T>(T a, T b) where T : IComparable<T>
//    {
//        return a.CompareTo(b) >= 0 ? a : b;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        int intMax = Helper.Max(10, 20);
//        Console.WriteLine($"Max of 10 and 20: {intMax}");

//        double doubleMax = Helper.Max(5.5, 2.8);
//        Console.WriteLine($"Max of 5.5 and 2.8: {doubleMax}");

//        string stringMax = Helper.Max("Apple", "Banana");
//        Console.WriteLine($"Max of \"Apple\" and \"Banana\": {stringMax}");
//    }
//}
#endregion
#region p12
//using System;

//public static class Helper2<T>
//{
//    // Generic method to replace all occurrences of oldValue with newValue
//    public static void ReplaceArray(T[] array, T oldValue, T newValue)
//    {
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i].Equals(oldValue))
//            {
//                array[i] = newValue;
//            }
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Example with integers
//        int[] intArray = { 1, 2, 3, 2, 4 };
//        Console.WriteLine("Original int array: " + string.Join(", ", intArray));
//        Helper2<int>.ReplaceArray(intArray, 2, 9);
//        Console.WriteLine("After replacement: " + string.Join(", ", intArray));

//        // Example with strings
//        string[] stringArray = { "apple", "banana", "apple", "cherry" };
//        Console.WriteLine("\nOriginal string array: " + string.Join(", ", stringArray));
//        Helper2<string>.ReplaceArray(stringArray, "apple", "orange");
//        Console.WriteLine("After replacement: " + string.Join(", ", stringArray));
//    }
//}
#endregion
#region p13
//using System;

//struct Rectangle
//{
//    public double Length { get; set; }
//    public double Width { get; set; }

//    public Rectangle(double length, double width)
//    {
//        Length = length;
//        Width = width;
//    }

//    public override string ToString()
//    {
//        return $"Length = {Length}, Width = {Width}";
//    }
//}

//class Program
//{
//    // Non-generic swap method for Rectangle
//    static void Swap(ref Rectangle r1, ref Rectangle r2)
//    {
//        Rectangle temp = r1;
//        r1 = r2;
//        r2 = temp;
//    }

//    static void Main()
//    {
//        Rectangle rect1 = new Rectangle(10, 5);
//        Rectangle rect2 = new Rectangle(20, 8);

//        Console.WriteLine("Before Swap:");
//        Console.WriteLine("Rectangle 1: " + rect1);
//        Console.WriteLine("Rectangle 2: " + rect2);

//        Swap(ref rect1, ref rect2);

//        Console.WriteLine("\nAfter Swap:");
//        Console.WriteLine("Rectangle 1: " + rect1);
//        Console.WriteLine("Rectangle 2: " + rect2);
//    }
//}
#endregion
#region p14
//using System;

//// Department class
//class Department
//{
//    public int Id { get; set; }
//    public string Name { get; set; }

//    public Department(int id, string name)
//    {
//        Id = id;
//        Name = name;
//    }

//    public override bool Equals(object obj)
//    {
//        if (obj is Department other)
//            return this.Id == other.Id;
//        return false;
//    }

//    public override int GetHashCode()
//    {
//        return Id.GetHashCode();
//    }

//    public override string ToString()
//    {
//        return Name;
//    }
//}

//// Employee class
//class Employee
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public Department Department { get; set; }

//    public Employee(int id, string name, Department department)
//    {
//        Id = id;
//        Name = name;
//        Department = department;
//    }

//    public override bool Equals(object obj)
//    {
//        if (obj is Employee other)
//            return this.Department.Equals(other.Department);
//        return false;
//    }

//    public override string ToString()
//    {
//        return $"Id: {Id}, Name: {Name}, Department: {Department}";
//    }
//}

//// Helper2 class with SearchArray
//class Helper2<T>
//{
//    public static int SearchArray(T[] array, T value)
//    {
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i].Equals(value))
//                return i;
//        }
//        return -1;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Departments
//        Department it = new Department(1, "IT");
//        Department hr = new Department(2, "HR");

//        // Employees
//        Employee[] employees =
//        {
//            new Employee(1, "Ahmed", it),
//            new Employee(2, "Sara", hr),
//            new Employee(3, "Omar", it)
//        };

//        // Search for employees in IT department
//        Employee searchEmployee = new Employee(0, "", it);

//        int index = Helper2<Employee>.SearchArray(employees, searchEmployee);

//        if (index != -1)
//            Console.WriteLine("Employee found: " + employees[index]);
//        else
//            Console.WriteLine("Employee not found");
//    }
//}
#endregion
#region p15
//using System;

//// ---------- STRUCT ----------
//struct CircleStruct
//{
//    public double Radius { get; set; }
//    public string Color { get; set; }

//    public CircleStruct(double radius, string color)
//    {
//        Radius = radius;
//        Color = color;
//    }
//}

//// ---------- CLASS ----------
//class CircleClass
//{
//    public double Radius { get; set; }
//    public string Color { get; set; }

//    public CircleClass(double radius, string color)
//    {
//        Radius = radius;
//        Color = color;
//    }

//    public override bool Equals(object obj)
//    {
//        if (obj is CircleClass other)
//            return Radius == other.Radius && Color == other.Color;
//        return false;
//    }

//    public override int GetHashCode()
//    {
//        return HashCode.Combine(Radius, Color);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // ===== STRUCT TEST =====
//        CircleStruct s1 = new CircleStruct(5, "Red");
//        CircleStruct s2 = new CircleStruct(5, "Red");

//        Console.WriteLine("STRUCT:");
//        Console.WriteLine("Equals: " + s1.Equals(s2));
//        // == is NOT allowed for structs unless overloaded
//        // Console.WriteLine(s1 == s2); //  compile-time error

//        // ===== CLASS TEST =====
//        CircleClass c1 = new CircleClass(5, "Red");
//        CircleClass c2 = new CircleClass(5, "Red");
//        CircleClass c3 = c1;

//        Console.WriteLine("\nCLASS:");
//        Console.WriteLine("Equals (same values): " + c1.Equals(c2));
//        Console.WriteLine("== (same values): " + (c1 == c2));
//        Console.WriteLine("== (same reference): " + (c1 == c3));
//    }
//}
#endregion
#region Problem 1: Generic Method for Reversing an Array
//using System;

//// Custom object example
//class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    public Person(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }

//    public override string ToString()
//    {
//        return $"{Name} ({Age})";
//    }
//}

//class Helper
//{
//    // Generic method to reverse an array
//    public static T[] ReverseArray<T>(T[] array)
//    {
//        T[] reversed = new T[array.Length];
//        for (int i = 0; i < array.Length; i++)
//        {
//            reversed[i] = array[array.Length - 1 - i];
//        }
//        return reversed;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Integer array
//        int[] numbers = { 1, 2, 3, 4, 5 };
//        int[] reversedNumbers = Helper.ReverseArray(numbers);
//        Console.WriteLine("Reversed integers: " + string.Join(", ", reversedNumbers));

//        // String array
//        string[] words = { "apple", "banana", "cherry" };
//        string[] reversedWords = Helper.ReverseArray(words);
//        Console.WriteLine("Reversed strings: " + string.Join(", ", reversedWords));

//        // Custom object array
//        Person[] people = {
//            new Person("Alice", 25),
//            new Person("Bob", 30),
//            new Person("Charlie", 28)
//        };
//        Person[] reversedPeople = Helper.ReverseArray(people);
//        Console.WriteLine("Reversed people:");
//        foreach (var person in reversedPeople)
//        {
//            Console.WriteLine(person);
//        }
//    }
//}
#endregion
#region Problem 2: Generic Class for a Stack
//using System;

//public class GenericStack<T>
//{
//    private T[] items;
//    private int top;
//    private int capacity;

//    public GenericStack(int size = 10)
//    {
//        capacity = size;
//        items = new T[capacity];
//        top = -1;
//    }

//    // Push an item onto the stack
//    public void Push(T item)
//    {
//        if (top == capacity - 1)
//        {
//            Console.WriteLine("Stack Overflow! Cannot push item.");
//            return;
//        }
//        items[++top] = item;
//    }

//    // Pop an item from the stack
//    public T Pop()
//    {
//        if (top == -1)
//            throw new InvalidOperationException("Stack Underflow! No items to pop.");
//        return items[top--];
//    }

//    // Peek at the top item without removing it
//    public T Peek()
//    {
//        if (top == -1)
//            throw new InvalidOperationException("Stack is empty.");
//        return items[top];
//    }

//    // Check if stack is empty
//    public bool IsEmpty()
//    {
//        return top == -1;
//    }

//    // Check if stack is full
//    public bool IsFull()
//    {
//        return top == capacity - 1;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Integer stack
//        GenericStack<int> intStack = new GenericStack<int>(5);
//        intStack.Push(10);
//        intStack.Push(20);
//        intStack.Push(30);
//        Console.WriteLine("Top of int stack: " + intStack.Peek());
//        Console.WriteLine("Popped: " + intStack.Pop());
//        Console.WriteLine("Top after pop: " + intStack.Peek());

//        // String stack
//        GenericStack<string> stringStack = new GenericStack<string>(3);
//        stringStack.Push("Apple");
//        stringStack.Push("Banana");
//        Console.WriteLine("\nTop of string stack: " + stringStack.Peek());
//        Console.WriteLine("Popped: " + stringStack.Pop());
//        Console.WriteLine("Top after pop: " + stringStack.Peek());
//    }
//}
#endregion
#region Problem 3: Generic Method for Swapping Elements
//using System;

//class Helper
//{
//    // Generic method to swap elements in an array
//    public static void Swap<T>(T[] array, int index1, int index2)
//    {
//        if (array == null || index1 < 0 || index2 < 0 || index1 >= array.Length || index2 >= array.Length)
//        {
//            Console.WriteLine("Invalid array or indices.");
//            return;
//        }

//        T temp = array[index1];
//        array[index1] = array[index2];
//        array[index2] = temp;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Integer array
//        int[] numbers = { 1, 2, 3, 4, 5 };
//        Console.WriteLine("Original integers: " + string.Join(", ", numbers));
//        Helper.Swap(numbers, 1, 3);
//        Console.WriteLine("After swapping index 1 and 3: " + string.Join(", ", numbers));

//        // String array
//        string[] words = { "apple", "banana", "cherry" };
//        Console.WriteLine("\nOriginal strings: " + string.Join(", ", words));
//        Helper.Swap(words, 0, 2);
//        Console.WriteLine("After swapping index 0 and 2: " + string.Join(", ", words));

//        // Custom object array
//        Person[] people = {
//            new Person("Alice", 25),
//            new Person("Bob", 30),
//            new Person("Charlie", 28)
//        };
//        Console.WriteLine("\nOriginal people:");
//        foreach (var p in people) Console.WriteLine(p);

//        Helper.Swap(people, 0, 2);
//        Console.WriteLine("\nAfter swapping index 0 and 2:");
//        foreach (var p in people) Console.WriteLine(p);
//    }
//}

//// Custom object for demonstration
//class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    public Person(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }

//    public override string ToString()
//    {
//        return $"{Name} ({Age})";
//    }
//}
#endregion
#region Problem 4: Generic Method for Finding Maximum Element
//using System;

//class Helper
//{
//    // Generic method to find maximum element
//    public static T MaxElement<T>(T[] array) where T : IComparable<T>
//    {
//        if (array == null || array.Length == 0)
//            throw new ArgumentException("Array is empty or null.");

//        T max = array[0];
//        for (int i = 1; i < array.Length; i++)
//        {
//            if (array[i].CompareTo(max) > 0)
//                max = array[i];
//        }
//        return max;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Integer array
//        int[] numbers = { 5, 10, 3, 8, 15 };
//        Console.WriteLine("Max integer: " + Helper.MaxElement(numbers));

//        // Double array
//        double[] doubles = { 2.5, 7.3, 1.8, 9.6 };
//        Console.WriteLine("Max double: " + Helper.MaxElement(doubles));

//        // String array
//        string[] words = { "apple", "banana", "cherry" };
//        Console.WriteLine("Max string: " + Helper.MaxElement(words));
//    }
//}
#endregion