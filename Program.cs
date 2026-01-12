namespace ConsoleApp1;

internal static class Program
{
    private static void Main()
    {
        var input = Console.ReadLine();
        if (int.TryParse(input, out var n)) Console.WriteLine(n + 1);
        Console.WriteLine(GameObject.Pi.ToString("F10"));
        var gameObject = new GameObject(0, 1, 2);
        gameObject.Print();
        List<int> list = new();
        list.Add(1);
        list.Add(1);
        // Array2<int> array2 = new(10, 10);
        Index2 index2 = new(0, 0);
        // array2[index2] = 1;
        var enumerator = Range();
        while (enumerator.MoveNext())
        {
            int num = enumerator.Current;
            Console.WriteLine(num);
            if (num == -1)
                break;
        }

        try
        {
            var str = Console.ReadLine();
            var number = int.Parse(str!);
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
        finally
        {
            Console.WriteLine("Ok");
        }
        var b = list.Select(l => l + 1).ToArray();
        var d = from VAR in b
            where VAR > 1
            select VAR;
        GameObject g = new(0, 1, 2);
        Vector2 a = g;
        a.Print();
    }

    private static IEnumerator<int> Range()
    {
        for (var i = 0; i < 10; i++) yield return i;
        yield return -1;
    }
}
