//let's learn a little bit of error handling in this program

class Program
{
    public static void Main(string[] args)
    {
        /*in one of the previous programs we wrote, I tried casting
         an integer to a byte and it worked but had the risk of
         overflow, so we used the checked keyword to give us the error.
         This time I will use a try catch block to handle the error that
         appears*/
        //same as java
        try
        {
            var num = "1234";
            byte sequence = Convert.ToByte(num);

            Console.WriteLine(num);
            Console.WriteLine(sequence);
        }
        catch (OverflowException e)
        {
            Console.WriteLine("The byte variable is out of it's limit, try a smaller value");
        }
        
        /*why would we use try catch blocks? Seeing red flashing errors on
         our console can be pretty depressing, try catch blocks help us
         avoid the red flashing errors and see a genuine message about
         what the error is, so that we can make the necessary changes*/
        
        //let's try one more example
        try
        {
            string str = "true";
            bool isAaronAwesome = Convert.ToBoolean(str);
            Console.WriteLine(str);
            Console.WriteLine(isAaronAwesome);

            if (isAaronAwesome)
            {
                Console.WriteLine("Aaron is the best");
            }
            else
            {
                Console.WriteLine("Aaron sucks");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("There was an error");
        }
    }
}