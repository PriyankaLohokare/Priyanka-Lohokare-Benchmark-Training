// See https://aka.ms/new-console-template for more information
abstract class shape
{
    public abstract double area();
}
class circle:shape
{
    double radius;
    public void setData(double radius)
    {
        this.radius = radius;

    }
    public override double area()
    {
        double pi = 3.14;
        return 3.14 * radius*radius;
    }
}
class rectanle:shape
{
    int length, bredth;
    public void setData(int length,int bredth)
    {
        this.length = length;
        this.bredth = bredth; 
    }
    public override double area()
    {
        return length * bredth;

    }

}
class test
{
    public static void Main(string[] args)
    {
        string choice;
        double radius;
        int length;
        int bredth;
        circle c=new circle();
        rectanle r=new rectanle();
        Console.WriteLine("Enter Your Choice");
        Console.WriteLine("Rectangle or circle");
        choice =Console.ReadLine();
        if (choice.Equals("circle"))
            
        {
            Console.WriteLine("Enter radius");
            radius =Convert.ToDouble(Console.ReadLine());
            c.setData(radius);
            Console.WriteLine("Area of Cicle is");
            Console.WriteLine(c.area());

        }
        else if(choice.Equals("rectangle"))
        {
            Console.WriteLine("Enter length");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter bredth");

            bredth = Convert.ToInt32(Console.ReadLine());

            r.setData(length,bredth);
            Console.WriteLine("Area of rectangle is");
            Console.WriteLine(r.area());
        }
        else
        {
            Console.WriteLine("Invalid choice!!");
        }
        Console.ReadKey();        
    }
}