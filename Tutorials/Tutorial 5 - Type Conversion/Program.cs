//there are 2 types of type conversion
//implicit & explicit

public class Program
{
    public static void Main(string[] args)
    {
        //we'll start with conversions between numerical data types
        //this is implicit
        byte sequence = 1;
        int x = sequence;

        Console.WriteLine(sequence);
        Console.WriteLine(x);
        
        /*the difference between implicit and explicit type conversion
         is the knowledge of risk of data loss. If the compiler believes
         that there will be some form of data loss when converting between
         the types, it won't perform any implicit type conversion, which
         is why a developer would have to explicitly mention that the type
         conversion must take place*/
        
        //here is an example of explicit
        int i = 1;
        //byte j = i;
        /*the above line of code won't compile because the int container is
         bigger than the container size of a byte type*/
        // so we can explicitly declare the conversion, also known as casting
        byte j = (byte) i;
        Console.WriteLine(i);
        Console.WriteLine(j);
        
        //but one data type that can prove to be difficult in converting is a
        //non-numerical data type to a numerical data type and vice versa
        string number = "256";
        //int stringCast = (int)number;
        
        /*the above line of code gives a compile error, why? Because the
         explicit conversion process doesn't work between a non-numerical
         and numerical data type set, so we can either pass or use the 
         Convert method*/ 
        
        int stringParse = Int32.Parse(number);
        //or
        int stringConvert = Convert.ToInt32(number);

        Console.WriteLine(number);
        Console.WriteLine(stringParse);
        Console.WriteLine(stringConvert);
        
        //but what about converting an int into string?
        int toString = 198;
        string intConvert = Convert.ToString(toString);

        Console.WriteLine("\n");
        Console.WriteLine(toString);
        Console.WriteLine(intConvert);
    }
}