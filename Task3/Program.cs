int[] values = { 3, 4, 2, 1, 5, 6 };

var result = values.Where((elem, index) => elem % 2 == 0 && index % 2 == 1);

Console.WriteLine(String.Join(", ", result));
Console.ReadKey();