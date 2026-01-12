// namespace ConsoleApp1;
//
// public class Array2<T>(byte width, byte height) : IEnumerable<T>
// {
//     private readonly T[,] _array2 = new T[width, height];
//
//     public T this[Index2 v]
//     {
//         get => _array2[v.X, v.Y];
//         set => _array2[v.X, v.Y] = value;
//     }
//     
//     IEnumerator<T> IEnumerable<T>.GetEnumerator() => new PeopleEnum(_people);
// }
//
// public class People : IEnumerable
// {
//     private Person[] _people;
//     public People(Person[] pArray)
//     {
//         _people = new Person[pArray.Length];
//
//         for (int i = 0; i < pArray.Length; i++)
//         {
//             _people[i] = pArray[i];
//         }
//     }
//
// // Implementation for the GetEnumerator method.
//     IEnumerator IEnumerable.GetEnumerator()
//     {
//         return (IEnumerator) GetEnumerator();
//     }
//
//     public PeopleEnum GetEnumerator()
//     {
//         return new PeopleEnum(_people);
//     }
// }