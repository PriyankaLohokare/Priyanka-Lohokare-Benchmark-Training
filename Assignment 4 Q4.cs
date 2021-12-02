// See https://aka.ms/new-console-template for more information
//Q4)	Use DirectoryInfo and FileInfo class and print details
 // of directories and files available in that directory
class fileprog
{
    public static void Main(string[] args)
    {
        DirectoryInfo di = new DirectoryInfo("D:\\.net\\file prog\\demodir");
        if(di.Exists)
        {
            Console.WriteLine(di.FullName);
            Console.WriteLine(di.CreationTime);
            Console.WriteLine(di.LastAccessTime);
            Console.WriteLine(di.LastWriteTime);

           //drive d and d.availablefreespace
            FileInfo[] fi=di.GetFiles();
            foreach(FileInfo fi2 in fi)
            {
                Console.WriteLine(fi2.Name);
                Console.WriteLine(fi2.CreationTime);
                Console.WriteLine(fi2.LastAccessTime);
                Console.WriteLine(fi2.Length);
                Console.WriteLine("########################");
            }
        }
        else
        {
            di.Create();
        Console.WriteLine("Dirctory Created");
        }
       Console.ReadKey();
    }
}
