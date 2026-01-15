namespace ConsoleApp1;

public readonly struct Int2(int x, int y) : IIntN<Int2>
{
    public int X => x;
    public int Y => y;
    
    public static Int2 operator +(Int2 a, Int2 b) => new(a.X + b.X, a.Y + b.Y);
}