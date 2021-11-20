// See https://aka.ms/new-console-template for more information
/* 3)	Create employee class as instructed in previous assignment
    and create array of 10 employees to store and print list of employees*/
class Employee
{
    private int id;
    private String ename;
    private int age;
    private double sal;

    public Employee(int id, String ename, int age, double sal)
    {
        this.id = id;
        this.ename = ename;
        this.age = age;

        this.sal = sal;
    }
    public void show()
    {
        
            Console.WriteLine("Employee id is: " + id);
            Console.WriteLine("Employee name is: " + ename);
            Console.WriteLine("Employee age is: " + age);
            Console.WriteLine("Employee salary is: " + sal);


        

    }
}
class test
{
    public static void Main(string[] args)
    {
        int n;
        Console.WriteLine("How many employee details you want to enter");
        n=Convert.ToInt32(Console.ReadLine());
        Employee[] obj = new Employee[n];
        int id,age;
        string ename;
        double sal;


        
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Enter {0} employee details: ", i);
            Console.WriteLine("enter employee id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter employee name: ");
            ename = Console.ReadLine();
            Console.WriteLine("enter employee age: ");
            age= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter employee salary: ");
            sal = Convert.ToDouble(Console.ReadLine());

            obj[i] = new Employee(id,ename,age,sal);
            Console.WriteLine("{0} employee details are:", i);
            obj[i].show();
            Console.ReadKey();

        }
        
        
    }
}