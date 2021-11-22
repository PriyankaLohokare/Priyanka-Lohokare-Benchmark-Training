// See https://aka.ms/new-console-template for more information
/*4)	Write a function to accept two numbers from user and divide nos. 
 * handle different types of exceptions possible in the code. Verify in main.*/
class program
{
    public static void Main(string[] args)
    {
        int Num1, Num2;
        double result;
        try
        { 
        Console.WriteLine("Enter First Number");
        Num1 =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second Number");
        Num2 = Convert.ToInt32(Console.ReadLine());
            result = Num1 / Num2;
            Console.WriteLine("Division of two number is" + result);
         }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Exception occured!! "+ex.Message);
        }
        catch (FormatException fe)
        {
            Console.WriteLine("Exception occured!! "+fe.Message);

        }
        Console.ReadKey();


    }
}
