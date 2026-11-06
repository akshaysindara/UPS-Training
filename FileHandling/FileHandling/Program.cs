using System;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        string filePath = "example.txt";

        FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
        StreamWriter sw = new StreamWriter(fs);
        sw.WriteLine("Hi Welcome to CIT!");
        sw.WriteLine("What do u want and How u doing??");
        sw.Close();
        fs.Close();

        FileStream fs1= new FileStream(filePath, FileMode.Append, FileAccess.Write);
        StreamWriter sw1 = new StreamWriter(fs1);
        sw1.WriteLine("This is an additional line.");
        sw1.Close();
        fs1.Close();

        FileStream fs5 = new FileStream(filePath, FileMode.Truncate);
        fs5.Close();


        using (FileStream fs2 = new FileStream(filePath, FileMode.Append, FileAccess.Write))
        {
            StreamWriter sw2 = new StreamWriter(fs2);
            string ans = "y";
            sw2.WriteLine("Vehicle Details");
            sw2.WriteLine("RegNo\t|\tModel\t|\tPrice");
            while (ans == "y")
            {
                Console.WriteLine("Enter Vechile Details: \n");
                Console.Write("Enter RegNo:");
                string? regno = Console.ReadLine();
                Console.Write("Enter Model: ");
                string? model = Console.ReadLine();
                Console.Write("Enter The Price: ");
                string? Price = Console.ReadLine();

                string details = $"{regno}\t|\t{model}\t|\t{Price}";
                sw2.WriteLine(details);
                Console.WriteLine("Do Want To Continue?(Y/N)");
                ans = Console.ReadLine().ToLower();
            }
            sw2.Close();
        }
    }
}