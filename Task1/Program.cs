var a = Fact().Take(10);
Console.WriteLine(String.Join(", ", a));

//var b = Enumerable.Range(1, 10).Select(x => Enumerable.Range(1, x).Aggregate((i, j) => i * j));
//Console.WriteLine(String.Join(", ", b));

Console.ReadKey();


static IEnumerable<int> Fact()
{
    int number = 1;
    while (true)
    {
        yield return Enumerable.Range(1, number).Aggregate((i, j) => i * j);
        number++;
    }
}