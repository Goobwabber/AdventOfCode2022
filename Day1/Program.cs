using Day1;

var lines = File.ReadAllLines("Input.txt");
var elves = new List<Elf>();

Elf elf = new();
foreach (var line in lines)
{
    if (line == "") 
    {
        elves.Add(elf);
        elf = new();
        continue;
    }

    var meow = int.Parse(line);
    elf.foods.Add(meow);
}

elves.Sort((a, b) =>
{
    return b.Calories() - a.Calories();
});

Console.WriteLine(elves.First().Calories());
Console.WriteLine(elves[0].Calories() + elves[1].Calories() + elves[2].Calories());