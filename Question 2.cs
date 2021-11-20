// See https://aka.ms/new-console-template for more information
/*2)	Create enumeration with name Days containing Day name as constants.
 * Write a method which is accepting enumeration as parameter and verify working of enumeration.*/
public enum days
{
    mon=1,
    tues,
    wed,
    thu,
    fri,
    sat,
    sun,
}
class test
{
    public static void Main(string[] args)
    {
   
        


        Console.WriteLine("Monday has value " + (int)days.mon);

      
        Console.WriteLine("Friday has value " + (int)days.fri);

       

    }
   


}
