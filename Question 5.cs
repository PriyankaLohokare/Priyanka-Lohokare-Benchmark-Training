// See https://aka.ms/new-console-template for more information
/*5)	Use class created in Example-3 and accept and print values for 10 employees(using loops)*/
class employee
{
    private int empno;
    private string empname;
    private string designation;
    private double salary;
    public int Empno
    {
        get { return empno; }
        set { empno = value; }
    }
    public string Empname
    {
        get { return empname; }
        set { empname = value; }
    }
    public string Designation
    {
        get { return designation; }
        set { designation = value; }
    }
    public double Salary
    {
        get { return salary; }
        set { salary = value; }
    }
}
class test
{
    public static void Main(string[] args)
    {
        employee e = new employee();
        int no;
        string ename, designation;
        double salary;
        int count;
        Console.WriteLine("How many employee details you want to enter: ");
        count = Convert.ToInt32(Console.ReadLine());
        int i = 1;
        while (i <=count)
        {
            Console.WriteLine("enter employee number: ");
            no = Convert.ToInt32(Console.ReadLine());
            e.Empno = no;
            Console.WriteLine("enter employee name: ");
            ename = Console.ReadLine();
            e.Empname = ename;
            Console.WriteLine("enter employee designation: ");
            designation = Console.ReadLine();
            e.Designation = designation;
            Console.WriteLine("enter employee salary: ");
            salary = Convert.ToDouble(Console.ReadLine());
            e.Salary = salary;

            Console.WriteLine(i+ "Employee details are as Follows: ");
            Console.WriteLine("Employee number is: " + e.Empno + "\n Employee name is: " + e.Empname + "\n Employee designation is: " +
                e.Designation + "\n Employee salary is: " + e.Salary);
            Console.WriteLine("\n");

            i++;

        }
        Console.ReadKey();
    }
}

