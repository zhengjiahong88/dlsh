namespace ConsoleApp1;

public class Car : IDisposable
{
    public void Dispose()
    {
        Console.WriteLine("Car disposed");
    }
}