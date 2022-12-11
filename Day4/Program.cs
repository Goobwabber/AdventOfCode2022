var lines = File.ReadAllLines("Input.txt");

var count = 0;
var count2 = 0;
foreach (var line in lines)
{
    var pairs = line.Split(',');

    var pair1 = pairs[0].Split('-');
    var pair2 = pairs[1].Split('-');

    var mew = int.Parse(pair1[0]);
    var mew2 = int.Parse(pair1[1]);
    var meww = int.Parse(pair2[0]);
    var meww2 = int.Parse(pair2[1]);

    if ((mew <= meww && mew2 >= meww2) || (mew >= meww) && (mew2 <= meww2))
        count++;
    if ((mew >= meww && mew <= meww2) || (meww >= mew && meww <= mew2))
        count2++;
}

Console.WriteLine(count);
Console.WriteLine(count2);