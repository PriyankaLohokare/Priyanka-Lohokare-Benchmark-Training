// See https://aka.ms/new-console-template for more information

/* 1)	Write a program in C# to verify operator overloading. 
 * Create student class containing marks as data member. 
 * Overload + ,- and == operator to add subtract and compare marks respectively.*/
namespace operatoroveloading
{
    class Student
    {
        private int marks;
        private string name1;
        private int age;

        public void SetName(string name1)
        {
            this.name1 = name1;
        }
        public void SetMarks(int marks)
        {
            this.marks = marks;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
        public void printdata()
        {
            Console.WriteLine(name1);
            Console.WriteLine(age);
            Console.WriteLine(marks);
        }

        public static Student operator +(Student a, Student b)
        {
            Student c = new Student();
            c.name1 = a.name1 + b.name1;
            c.marks = a.marks + b.marks;
            c.age = a.age + b.age;
            return c;

        }
        public static Student operator -(Student a, Student b)
        {
            Student c = new Student();
            c.name1 = a.name1;
            c.marks = a.marks - b.marks;
            c.age = a.age - b.age;
            return c;

        }
        public static Student operator *(Student a, Student b)
        {
            Student c = new Student();
            c.name1 = b.name1;
            c.marks = a.marks * b.marks;
            c.age = a.age * b.age;
            return c;

        }
        public static bool operator ==(Student a, Student b)
        {
            if (a.marks == b.marks)
                return true;
            else
                return false;
        }
        public static bool operator !=(Student a, Student b)
        {
            if (a.marks != b.marks)
                return true;
            else
                return false;
        }


        class mainn
        {
            public static void Main(string[] args)
            {
                Student s1 = new Student();
                Student s2 = new Student();
                Student s3 = new Student();
                s1.SetMarks(100);
                s1.SetName("priya");
                s1.SetAge(20);
                s2.SetMarks(200);
                s2.SetName("priyanka");
                s2.SetAge(23);
                Console.WriteLine("+ operator");
                s3 = s1 + s2;
                s3.printdata();
                Console.WriteLine("- operator");
                s3 = s2 - s1;
                s3.printdata();
                Console.WriteLine("* operator");
                s3 = s2 * s1;
                s3.printdata();
                Console.WriteLine("== operator");

                Console.WriteLine(s1 == s2);
                Console.WriteLine("!= operator");

                Console.WriteLine(s1 != s2);






                Console.ReadKey();

            }
        }



    }
}
