//let's practice format strings with placeholders

public class Placeholders
{
    public static void Main(string[] args)
    {
        //these are usually used when trying to add on variables into string outputs
        Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
        
        //here we will use variables instead
        string name = "Aaron";
        int age = 23;
        Console.WriteLine("Hi my name is {0} and I am {1} years old", name, age);
        
        /*so these are formatted strings that contain pre-defined data mixed
         in with some variables that we may or may not have the values of at 
         the time*/
    }
}