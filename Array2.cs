using System.Collections;

namespace ConsoleApp1;

public class Array2<T>(ushort width, ushort height) : IArrayN<T>
{
    public readonly Size2 Size = new(width, height);
    
    private readonly T[,] _array = new T[width, height];
    
    public T this[Int2 int2]
    {
        get => _array[int2.X, int2.Y];
        set => _array[int2.X, int2.Y] = value;
    }

    public IArrayN<TOther> CloneAs<TOther>() => new Array2<TOther>(width, height);
    
    public IEnumerator<T> GetEnumerator() => Size.Select(position => this[position]).GetEnumerator();
    
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public IEnumerable<T> Transpose() => Size.Transpose().Select(position => this[position]);
}