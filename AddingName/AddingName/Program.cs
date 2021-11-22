var names = new List<string> { "Artem", "Sasha", "Masha" };
names.Add  ("Andrey");
foreach (var name in names)
{
Console.WriteLine($"hello { name.ToUpper()}");
}
var index = names.IndexOf("Andrey");
if (index != -1)
    Console.WriteLine($"The name {names[index]} is at index {index}");

var notFound = names.IndexOf("Not Found");
Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");
