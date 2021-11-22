// See https://aka.ms/new-console-template for more information
/*3)	Create interface with name IPrintable and print method. 
 * implement interface in Account and employee class. 
 * Verify in main class and check working.*/
interface IPrintable
{
    void print();
}
class Account:IPrintable
{
    int AccNo;
    String AccName;
    string AccType;
    public Account(int AccNo,String AccName, string AccType)
    {
        this.AccNo = AccNo;
        this.AccName = AccName;
            this.AccType = AccType;
    }


    public void print()
    {
        Console.WriteLine("Account details are");
        Console.WriteLine("Account no is: " + AccNo + " Name is: " + AccName + " Account type is: " + AccType);
    }
}
class Employee : IPrintable
{
    int EmpNo;
    String EmpName;
    string Designation;
    public Employee(int EmpNo,string EmpName,string Designation)

    {
        this.EmpNo = EmpNo;
        this.EmpName = EmpName;
            this.Designation = Designation;
        
    }


    public void print()
    {
        Console.WriteLine("Employee details are");
        Console.WriteLine("Employee no is: " + EmpNo + " Employee Name is: " + EmpName + " Employee Designation is: " + Designation);
    }
}
class test
{
    public static void Main(string[] args)
    {
        Account a = new Account(111, "Riya", "Saving");
        a.print();
        Employee e = new Employee(101,"priyanka","Project Trainee");
        e.print();
        Console.ReadKey();
    }
}
