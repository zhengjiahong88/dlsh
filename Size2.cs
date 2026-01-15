using System.Collections;

namespace ConsoleApp1;

public readonly struct Size2(ushort width, ushort height) : IEnumerable<Int2>
{
    public IEnumerator<Int2> GetEnumerator()
    {
        for (var y = 0; y < height; y++)
        for (var x = 0; x < width; x++)
            yield return new Int2(x, y);
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public IEnumerable<Int2> Transpose()
    {
        for (var x = 0; x < width; x++)
        for (var y = 0; y < height; y++)
            yield return new Int2(x, y);
    }
}