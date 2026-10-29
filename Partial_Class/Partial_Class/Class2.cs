using System;


namespace Employee
{
    public partial class Manager : Outside
    {
        public partial void info();
        public void location()
        {
            Console.WriteLine("Chennai");
        }

        public void dept()
        {
            Console.WriteLine("ITSM");
        }
    }
    

}
