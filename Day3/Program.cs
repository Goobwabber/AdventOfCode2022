using Day3;

var lines = File.ReadAllLines("Input.txt");

/*var lines = new string[]
{
    "PPZTzDhJPLqPhqDTqrwQZZWbmCBMJMcsNmCBFWmMcsNb",
    "vplSlfdfGvfRRGsgNcMglsFWMWMC",
    "jtjvFHdjjwqrwqwL",
    "NSffhsNSjfLjfstsjtjNNjjqMqnpggHngqgHGHCgClGbCzCC",
    "dDPZZDZFdwFWwFZFWZRTFDwGzCMlgnpgCpnzglClHMbg",
    "DTPFZQRcdTVNhbjVbcLc"
};*/

int priorities = 0;
foreach(var line in lines)
{
    Items meewewew = Items.cumm;
    int length = line.Length;
    int length2 = length / 2;

    for (int i = 0; i < length2; i++)
    {
        int meow;
        if (line[i] < 91)
            meow = line[i] - 39;
        else
            meow = line[i] - 97;

        Items mewww = (Items)((ulong)0x1 << meow);
        meewewew |= mewww;
    }

    for (int i = length2; i < length; i++)
    {
        int meow;
        if (line[i] < 91)
            meow = line[i] - 39;
        else
            meow = line[i] - 97;

        Items mewww = (Items)((ulong)0x1 << meow);
        if (meewewew.HasFlag(mewww))
        {
            priorities += meow + 1;
            break;
        }
    }
}

Console.WriteLine(priorities);

int priorities2 = 0;
for(int i = 0; i < lines.Length /3; i++)
{
    Items mewwwww = Items.All;
    for (int x = 0; x < 3; x++)
    {
        var line = lines[i * 3 + x];
        Items hhhhh = Items.cumm;

        foreach(var character in line)
        {
            int meow;
            if (character < 91)
                meow = character - 39;
            else
                meow = character - 97;

            Items graaaaah = (Items)((ulong)0x1 << meow);
            if (x == 2 && mewwwww.HasFlag(graaaaah))
            {
                priorities2 += meow + 1;
                break;
            }

            hhhhh |= graaaaah;
        }
        mewwwww &= hhhhh;
    }
}

Console.WriteLine(priorities2);