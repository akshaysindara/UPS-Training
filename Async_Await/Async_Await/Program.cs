using System;

class Program
{
    public static async Task Loading(CancellationToken token)
    {
        
        Console.WriteLine("Loading....");
        for (int i = 0; i < 20; i++)
        {
            token.ThrowIfCancellationRequested();
            Console.Write("---");

            await Task.Delay(1000);
        }
        Console.WriteLine("Loading Completed!");
    }
    public static async Task Main(string[] args)
    {
        CancellationTokenSource cts = new CancellationTokenSource();
        Console.WriteLine("Loading Intiated ");
        Console.WriteLine("Press C to Cancel ");
        Task key = Task.Run(() =>
        {
            while (!cts.IsCancellationRequested)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.C)
                    {
                        cts.Cancel();
                        break;
                    }
                }
            }
        });

        try
        {
            await Loading(cts.Token);
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("\nLoading was canceled.");
        }
        finally
        {
            cts.Dispose();
        }
        await key;

        Console.WriteLine("Task Completed");
    }
}