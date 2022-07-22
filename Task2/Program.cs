int[] values = { 1, 2, 3, 4, 5, 6 };

var result = Extensions.Rotate(values, 14);
Console.WriteLine(String.Join(", ", result));
Console.ReadKey();

internal static class Extensions
{
    internal static IEnumerable<int> Rotate(this IEnumerable<int> source, int n)
    {
        n = n % source.Count();
        return source.Skip(n).Take(source.Count() - n).Concat(source.Take(n));
    }
}