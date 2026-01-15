namespace ConsoleApp1;

public class GameObject(float x, float y, int n) : Vector2(x, y)
{
    public const float Pi = 3.14159265358979323846f;

    public override void Print()
    {
        base.Print();
        Console.WriteLine(Pi);
    }

    public void Example(){}
}