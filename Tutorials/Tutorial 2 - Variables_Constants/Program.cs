//this program is to demonstrate variables and constants in C#

public class Program
{
    public static void Main(string[] args)
    {
        //we can start with integers
        short age = 23;
        //do primitives in C# have a corresponding Object type? Like Java?
        //NO there are no corresponding object types for each primitive type
        //instead we get the usual C# types and .NET types corresponding to them
        int mathMarks = 78;
        long ictMarks = 92;
        float average = 3.27f;
        double runSpeed = 72.3456;
        byte sequence = 255;
        char option = 'a';
        bool isAaronAwesome = true;
        decimal salary = 235000;
        string schoolClass = "13ComE";

        //print statements, shortcut - cw
        Console.WriteLine(age);
        Console.WriteLine(mathMarks);
        Console.WriteLine(ictMarks);
        Console.WriteLine(average);
        Console.WriteLine(runSpeed);
        Console.WriteLine(sequence);
        Console.WriteLine(option);
        Console.WriteLine(isAaronAwesome);
        Console.WriteLine(salary);
        Console.WriteLine(schoolClass);
        Console.WriteLine("\n");
        
        //object types (besides string, everything is from .NET)
        String name = "Aaron";
        Int16 num1 = 432;
        Int32 num2 = 414;
        Int64 num3 = 7853;
        Byte byteSequence = 255;
        Single floatDotNetType = 45.12f;
        Double doubleDotNetType = 231.5621d;
        Decimal payment = 56000;

        Console.WriteLine(name);
        Console.WriteLine(num1);
        Console.WriteLine(num2);
        Console.WriteLine(num3);
        Console.WriteLine(byteSequence);
        Console.WriteLine(floatDotNetType);
        Console.WriteLine(doubleDotNetType);
        Console.WriteLine(payment);
        Console.WriteLine("\n");
        
        //constants in C#, no different from Java or C++
        const double PI = 3.1415;
        Console.WriteLine(PI);

        //C#, unlike C++ and Java has the option to use var like in JS
        //this var has automatic type inference
        var book = "Jack Reacher: Days Gone";
        Console.WriteLine(book);
        
        /*although var seems pretty easy to use and helpful, it is recommended
        to use it only if necessary*/
    }
}