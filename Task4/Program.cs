var entries = new List<Entry>() {
    new Entry("John", "4(815)162342", true),
    new Entry("Sara", "4(815)162342", true),
    new Entry("Rob", "345678", false),
    new Entry("Tedd", "345678", false),
    new Entry("Lucie", "4(815)3789665", true),
    new Entry("Kurl", "345678", false),
    new Entry("Diego", "4(815)37468", true),
};

var result = entries.Where(x => x.IsPortable == true).OrderBy(x => x.Name);

int i = 1;
foreach (var entry in result)
    Console.WriteLine($"{i++}) {entry.Name} - {entry.Phone}");

Console.ReadKey();

class Entry
{
    public Entry(string? name, string? phone, bool isPortable)
    {
        Name = name;
        Phone = phone;
        IsPortable = isPortable;
    }

    public string? Name { get; set; } // имя абонента
    public string? Phone { get; set; } // номер телефона
    public bool IsPortable { get; set; } // это мобильный телефон


}
