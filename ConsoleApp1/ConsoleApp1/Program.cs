using System;
class Student
{
    static void Main(string[] args)
    {
        //Console.Write("Enter your name: ");
        //String name = Console.ReadLine();
        //Console.Write("Enter Age:");
        //var age = Convert.ToString
        //Console.WriteLine("Hello, {0}! You are {1} years old.", name, age);
        //Console.Write("Enter Ur Percentage: ");
        //int p=Convert.ToInt32(Console.Read());
        //string o = (p > 80) ? ("Eligible") : ("Not Eligible");
        //Console.WriteLine("You Are "+ p);
        /*if (p < 50)
        {
            Console.WriteLine("Fail");
        }
        else if (p < 60)
        {
            Console.WriteLine("D Grade");
        }
        else if (p < 70)
        {
            Console.WriteLine("C Grade");
        }
        else if (p < 80)
        {
            Console.WriteLine("B Grade");
        }
        else if (p < 90)
        {
            Console.WriteLine("A Grade");
        }
        else
        {
            Console.WriteLine("O Grade");
        }*/
        Console.Write("Enter ur Current Year: ");
        string y = Console.ReadLine();
        if (y == "final")
        {
            Console.Write("Enter No Of Backlogs:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 0)
            {
                Console.Write("Enter CGPA:");
                float cgpa=Convert.ToSingle(Console.ReadLine());
                if (cgpa > 8.0)
                {
                    Console.WriteLine("You Are Eligible!!");
                }
                else
                {
                    Console.WriteLine("CGPA Has Not Met");
                }
            }
            else
            {
                Console.WriteLine("Backlogs Exceeded");
            }

        }
        else
        {
            Console.WriteLine("Only Final Years Are Eligible");
        }


        /*for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i * i);
        }*/

    }
}