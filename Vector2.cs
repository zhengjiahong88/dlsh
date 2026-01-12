namespace ConsoleApp1;

public class Vector2(float x, float y)
{
    public virtual void Print()
    {
        Console.WriteLine($"({x}, {y})");
    }
}