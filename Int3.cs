namespace ConsoleApp1;

public readonly struct Int3(int x, int y, int z) : IIntN<Int3>
{
    public int X => x;
    public int Y => y;
    public int Z => z;
    
    public static Int3 operator +(Int3 a, Int3 b) => new(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
}