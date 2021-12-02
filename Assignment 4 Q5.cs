//Q5 5)	Create list containing rollno as key and Name as value and
//print details of students(use generic and non generic collection type both)
using System;
using System.Collections.Generic;
class prog
{
    static void Main(string[] args)
    {
        Dictionary<int, string> emp = new Dictionary<int, string>();
        emp.Add(101, "Priya");
        emp.Add(102, "Yash");

        foreach (KeyValuePair<int,string> emp1 in emp)
        {
            Console.WriteLine(emp1.Key + " " + emp1.Value);
        }
            Console.ReadKey();
    }
}
