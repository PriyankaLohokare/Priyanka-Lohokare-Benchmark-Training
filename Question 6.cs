// See https://aka.ms/new-console-template for more information
/*6)	Create an array try to accept values from user handle IndexOutOfBounds Exception.*/
class program
{
    public static void Main(string[] args)
    {
        try
        {

            int[] arr = new int[5];
            Console.WriteLine("How many elements in array");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter no");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]+" ");
            }
        }
        catch (IndexOutOfRangeException ex)
        {
           Console.WriteLine("Exception occured!! "+ex.Message);
        }
        catch (FormatException fe)
        {
            Console.WriteLine("Exception occured!! "+fe.Message);
        }



}
}
