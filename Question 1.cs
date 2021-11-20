// See https://aka.ms/new-console-template for more information
/*
1)	Write a program in C# to print fibonacci series from 0 to n or less than n(n is number entered by user) 
    0,1,1,2,3,5,8…*/

class Fibonacci 
{
    public static void Main(string[] args)
    {
        int num1 = 0, num2 = 1, num3, no;
        Console.Write("Enter no of elements you want in sereis ");
        no = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(num1);
        Console.WriteLine(num2);
        for (int i = 2; i < no;++i)     
        {
            num3 = num1 + num2;
            Console.WriteLine(num3 +" ");
            num1 = num2;
            num2 = num3;
        }
        Console.ReadKey();
    }

}
