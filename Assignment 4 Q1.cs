// See https://aka.ms/new-console-template for more information 
//Q1 1)	Write a program in C# to create Date class override ToString() and Equals function
//to print object details and to compare objects respectively.
//Call in main and verify
class Student
{
    public int Rollno { get; set; }

    public string Name { get; set; }
    public string Cname { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return "Person: " + Rollno + " " + Name + " " + Cname + " " + Age;
    }
}
class test
{
    public static void Main(string[] args)
    {
        Student s = new Student();
        Console.WriteLine("enter student Rollno");
        int rollno = Convert.ToInt32(Console.ReadLine());
        s.Rollno = rollno;
        Console.WriteLine("enter student name");
        string name = Console.ReadLine();
        s.Name = name;
        Console.WriteLine("enter student class name");
        string cname = Console.ReadLine();
        s.Cname = cname;

        Console.WriteLine("enter student age");
        int age = Convert.ToInt32(Console.ReadLine());
        s.Age = age;
        Console.WriteLine(s);
        Console.ReadKey();



    }
}

