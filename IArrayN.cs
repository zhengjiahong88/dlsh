namespace ConsoleApp1;

public interface IArrayN<out T> : IEnumerable<T>
{
    public IArrayN<TOther> CloneAs<TOther>();
}