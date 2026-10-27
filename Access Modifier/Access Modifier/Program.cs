using System;

public class AccessModifier
{
    public void Test1()
    {
        Console.WriteLine("Public Modifier");
    }

    private void Test2()
    {
        Console.WriteLine("Private Modifier");
    }

    protected void Test3()
    {
        Console.WriteLine("Protected Modifier");
    }

    internal void Test4()
    {
        Console.WriteLine("Internal Modifier");
    }

    internal protected void Test5()
    {
        Console.WriteLine("Internal Protected Modifier");
    }
    public void Main1()
    {
        Console.WriteLine("\n\nSame Class");
        AccessModifier a1 = new AccessModifier();
        a1.Test1();
        a1.Test2();
        a1.Test3();
        a1.Test4();
        a1.Test5();
    }

}

class Program1 
{
    public void Main2()
    {
        Console.WriteLine("\n\nAnother Class");
        AccessModifier a1 = new AccessModifier();
        a1.Test1();
        //a1.Test2();
        //a1.Test3();
        a1.Test4();
        a1.Test5();
    }
}

public class Program2 : AccessModifier
{
    public static void Main()
    {
        Console.WriteLine("Inherited Class");
        Program2 a1 = new Program2();
        a1.Test1();
        //a1.Test2();
        a1.Test3();
        a1.Test4();
        a1.Test5();

        Program1 a2 = new Program1();
        a2.Main2();

        AccessModifier a3 = new AccessModifier();
        a3.Main1();
    }
}