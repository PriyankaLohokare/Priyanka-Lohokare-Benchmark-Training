// See https://aka.ms/new-console-template for more information
abstract class Animal
{
    public abstract void Foodhabits();
    public void behaviour()
    {
        Console.WriteLine("All animal eat,walk,make different sounds");
    }

}
class herbivore:Animal
{
    public override void Foodhabits()
    {
        Console.WriteLine("An herbivore" +
            " is an animal or insect that only eats vegetation, " +
            "such as grasses, fruits, leaves, vegetables, roots and bulbs");
    }
}
class carnivore : Animal
{
    public override void Foodhabits()
    {
        Console.WriteLine("A carnivore is type of animal that mostly eats meat, or the flesh of animals");
    }
}
class test
{
    public static void Main(string[] args)
    {
        herbivore h=new herbivore();
        carnivore c=new carnivore();
        h.behaviour();
        Console.WriteLine("Food Habits of herbivore:");
        h.Foodhabits();
        Console.WriteLine("Food Habits of carnivore:");
        c.Foodhabits();
        Console.ReadKey();
    }
}