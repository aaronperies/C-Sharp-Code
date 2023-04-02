//this tutorial is created to demonstrate the purposes of the checked block in C#
//it helps with catching errors in possible code blocks

//for example, let's assume I wanted to create a byte variable
byte sequence = 255;

//now I will try adding + 1 to that variable and printing out the result
Console.WriteLine(sequence += 1);

//so why do we get 0 as the output? Because we have overflown the valid data
//range for the byte type variable which is 255

//now we'll try executing the same code but within a checked block
checked
{
    byte number = 255;
    Console.WriteLine(number += 1);
}
//this checked block throws a overflow exception which let's us know what the error is