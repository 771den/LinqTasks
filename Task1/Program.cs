var a = Fact().Take(10);
Console.WriteLine(String.Join(", ", a));

Console.ReadKey();

static IEnumerable<int> Fact()
{
    int number = 1;
    int acum = 1;
 
    while (true)
        yield return acum *= number++;
}