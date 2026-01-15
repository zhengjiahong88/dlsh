namespace ConsoleApp1;

internal static class Program
{
    private static void Main()
    {
        // var input = Console.ReadLine();
        // if (int.TryParse(input, out var n)) Console.WriteLine(n + 1);
        // Console.WriteLine(GameObject.Pi.ToString("F10"));
        // var gameObject = new GameObject(0, 1, 2);
        // gameObject.Print();
        // List<int> list = new();
        // list.Add(1);
        // list.Add(1);
        // Array2<int> array = new(10, 10);
        // int[] numbers = array.ToArray();
        // Array.BinarySearch(numbers, new Int2(0, 0));
        // foreach (var position in array.Size) array[position] = 1;
        // foreach (var n in array) Console.WriteLine(n);
        // var charArray = array.CloneAs<char>();
        //
        // try
        // {
        //     var str = Console.ReadLine();
        //     var number = int.Parse(str!);
        // }
        // catch (Exception exception)
        // {
        //     Console.WriteLine(exception.Message);
        // }
        // finally
        // {
        //     Console.WriteLine("Ok");
        // }
        // var b = list.Select(l => l + 1).ToArray();
        // var d = from VAR in b
        //     where VAR > 1
        //     select VAR;
        // GameObject g = new(0, 1, 2);
        // Vector2 a = g;
        // a.Print();
        Console.Write(123.ToString("D5"));
        Vector2 vector = new GameObject(10, 10, 2);
        Delegate.Example();
        dynamic obj = "hello";
        Console.WriteLine(obj.Length); // 執行期呼叫 string.Length
        obj = 123;
        Console.WriteLine(obj + 7);
        int[,] array2 = new int[2, 2];
        int n = 0;
        foreach (var position in new Size2(2, 2)) array2.Set(position, n++);
        Array.Sort(array2);
        foreach (var position in new Size2(2, 2)) Console.WriteLine($"{position}{array2.Get(position)}");
        Int2 pos = new(0, 0);
        array2.Set(pos, 10);

        List<int> collection = new();
        
        foreach (var item in collection) foreach (var i in collection)
        {
            Console.WriteLine(item);
        }

        var enumerator = collection.GetEnumerator();
        try
        {
            while (enumerator.MoveNext())
            {
                var item = enumerator.Current;
                Console.WriteLine(item);
            }
        }
        finally
        {
            (enumerator as IDisposable)?.Dispose();
        }

        foreach (var i in Range(10)) Console.WriteLine(i);
        
        foreach (var (i, value) in Enumerate(collection)) Console.WriteLine(i + value);
        
        var valueType = ValueTypes.Bool;
        if (valueType == ValueTypes.Bool)
        {
            Console.WriteLine(valueType);
            valueType = ValueTypes.Int;
        }

        int an = 0, b = 0;
        (an, b) = (b, an);
        
        using Car car = new();

        File.WriteAllText("text.txt", "text");
        
        ProcessNumbers(() => true);
    }

    private static IEnumerable<int> Range(int n)
    {
        for (var i = 0; i < n; i++) yield return i;
        yield return -1;
    }

    private static IEnumerable<(int, T)> Enumerate<T>(IEnumerable<T> enumerable)
    {
        var index = 0;
        foreach (var element in enumerable) yield return (index++, element);
    }

    public static void ProcessNumbers(Func<bool> predicate)
    {
        if (predicate()) Console.WriteLine("  123");
    }

    private static bool ProcessNumber() => true;
    
    private static T Set<T>(this T[,] array, Int2 position, T value) => array[position.X, position.Y] = value;
    private static T Get<T>(this T[,] array, Int2 position) => array[position.X, position.Y];
}