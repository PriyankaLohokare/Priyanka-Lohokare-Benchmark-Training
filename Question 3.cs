// See https://aka.ms/new-console-template for more information
/* 3)	Create a class Employee with data members empno, ename, designation and salary. 
  Write public methods to accept and print values of all the data members.
  Call and verify class functionality using main method.*/
class employee
{
    private int empno;
    private string empname;
    private string designation;
    private double salary;
    public void SetEmpno(int empno)
    {
        this.empno = empno;
    }
    public void SetEmpname(string empname)
    {
        this.empname = empname;
    }
    public void SetDesignation(string designation)
    {
        this.designation = designation;
    }
    public void SetSalary(double salary)
    {
        this.salary = salary;
    }
    public void PrintData()
    {
        Console.WriteLine("Employee Number is: " + empno + "\n emplyee name is:" + empname + "\n employee designation is:"
            + designation + "\n employee salary is:" + salary);

    }


}
class test
{
    public static void Main(string[] args)
    {
        int empno;
     string empname;
     string designation;
    double salary;
    employee e=new employee();
        Console.WriteLine("Enter Employee Number: ");
        empno=Convert.ToInt32(Console.ReadLine());
        e.SetEmpno(empno);
        Console.WriteLine("Enter Employee Name: ");
        empname=Console.ReadLine();
        e.SetEmpname(empname);
        Console.WriteLine("Enter Employee designation: ");
        designation = Console.ReadLine();
        e.SetDesignation(designation);
        Console.WriteLine("Enter Employee salary: ");
        salary = Convert.ToDouble(Console.ReadLine());
        e.SetSalary(salary);
        Console.WriteLine("Employee details are: ");
        e.PrintData();

        Console.ReadKey();
    }
}
