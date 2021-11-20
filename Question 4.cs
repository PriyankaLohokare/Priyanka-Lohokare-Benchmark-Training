// See https://aka.ms/new-console-template for more information\
/*4)	Write Average function to verify working param array. Pass different no of parameters and verify*/

class paramArray
{
    public float avgarray(params int[] arr)
    {
        int sum = 0;
        float avg;
        int l=arr.Length;

        foreach (int i in arr)
        {
          sum=sum+i;
        }
        avg=(sum)/l;
        return avg;

    }
    
   
   
}
class main
{
    public static void Main(string[] args)
    {
        paramArray p=new paramArray();
        Console.WriteLine("Average of array is "+p.avgarray(1, 2, 3, 4, 5));
       Console.WriteLine("Average of array is " + p.avgarray(2, 3, 4, 5,90));
        Console.WriteLine("Average of array is " + p.avgarray(11, 44, 33, 222));
        Console.ReadKey();
    }
}
