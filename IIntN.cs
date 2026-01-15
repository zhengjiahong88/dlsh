namespace ConsoleApp1;

public interface IIntN<TIntN> where TIntN : IIntN<TIntN>
{
    static abstract TIntN operator +(TIntN a, TIntN b);
}