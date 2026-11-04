using System;

public delegate void Eventhandler();

class Button
{
    public event Eventhandler? Click;
    public void OnClick()
    {
        Console.WriteLine("Button clicked");
        Click?.Invoke();
    }
    public void SimulateClick()
    {
        Console.WriteLine("Simulating button click...");
        OnClick();
    }
    public static void Main(string[] args)
    {
        Button button = new Button();
        button.Click += () => Console.WriteLine("Button click event handled.");
        button.SimulateClick();
    }
}