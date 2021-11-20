// See https://aka.ms/new-console-template for more information
/* 5) Create Employee as base class and permanent and waged employee
 as child class as per discussion in theory session. Execute and understand working in inheritance*/
class employee
{
    int id;
     String ename;
    public employee(int id, String ename)
    {
        this.id = id;
        this.ename = ename;
    }
    public void print()
    {
    Console.WriteLine(" id is"+id+" employee name is "+ename);
        }
    
}
class peremp:employee
{
   
    double basic;
    double hra;
    double da;
    double sal;
    public peremp(int id,string ename,double basic):base(id,ename)
    {
        this.basic = basic;
    }
    public void calsal()
    {
        hra = 0.5 * basic;
        da = 0.7 * basic;
        sal = basic + hra + da;
        base.print();
        Console.WriteLine("salary of permenant employee is" + sal);
    }
}
class wageemp:employee
{
    int hours;
    double amount;
    double sal;
    public wageemp(int id, string ename, int hours,double amount) : base(id, ename)
    {
        this.hours = hours;
        this.amount=amount;
    }
    public void calsal()
    {
     
        sal = hours*amount;
        base.print();
        Console.WriteLine("salary of dailywages employee is" + sal);
    }

}
class main
{
    public static void Main(string[] arg)
    {
        peremp e1 = new peremp(12, "priya", 30000);
        e1.calsal();
        wageemp e2 = new wageemp(13, "riya", 13,1200);
        e2.calsal();
        Console.ReadKey();
    }

}

