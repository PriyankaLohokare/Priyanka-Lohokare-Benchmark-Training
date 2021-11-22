// See https://aka.ms/new-console-template for more informations
/*2)	Create parent class and child class use sealed keyword for class and dummy method
 * and verify behavior.*/
sealed class student
{
    public void print()
    {
        Console.WriteLine("This class can't inherit from other class");
    }
}
class employee
{
    public virtual void print()
    {
    Console.WriteLine("This is employee class print method");
    }
    public virtual void show()
    {
        Console.WriteLine("employee class show method");
    }
}
class peremployee:employee
{
    sealed public override void print()
    {
        base.print();
        Console.WriteLine(" This is permenant employee class method.This method is sealed you can't oveeride it further");
    }
     public override void show()
    {
        base.show();
        Console.WriteLine("permanentemployee class show method");
    }
}
class intern:peremployee
{
    public override void show()
    {
        base.show();
        Console.WriteLine("intern  class show method");
    }
}
class main
{
    public static void Main(string[] args)
    {
        Console.WriteLine("sealed class implementation");
        student s=new student();
        s.print();
        Console.WriteLine("sealed method implementation");
        intern i=new intern();
        i.print();
        Console.WriteLine("override method implementation");
        i.show();
        Console.ReadKey();
    }
}

