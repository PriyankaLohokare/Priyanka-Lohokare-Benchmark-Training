// See https://aka.ms/new-console-template for more information
/*2)	Write a program to accept month number from user and print no of day in month. 
 * 
 * For eg. If user enters 1 then “31 days in month”(use switch case)
class switchcase_example*/
{
    public static void Main(string[] args)
    {
        int number;
        Console.WriteLine("Enter Month Number");
        number =Convert.ToInt32(Console.ReadLine());
        switch (number)
        {
            case 1:
                Console.WriteLine("31 days in month");
                break;
            case 2:
                Console.WriteLine("29 days in month");
                break;
            case 3:
                Console.WriteLine("31 days in month");
                break;
            case 4:
                Console.WriteLine("30 days in month");
                break;
            case 5:
                Console.WriteLine("31 days in month");
                break;
            case 6:
                Console.WriteLine("30 days in month");
                break;
            case 7:
                Console.WriteLine("31 days in month");
                break;
            case 8:
                Console.WriteLine("31 days in month");
                break;
            case 9:
                Console.WriteLine("30 days in month");
                break;
            case 10:
                Console.WriteLine("31 days in month");
                break;
            case 11:
                Console.WriteLine("30 days in month");
                break;
            case 12:
                Console.WriteLine("31 days in month");
                break;
            default:
                Console.WriteLine("Invalid month number!!");
                break;
                Console.ReadKey();
        }
    }
}
