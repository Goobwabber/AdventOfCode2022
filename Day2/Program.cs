var lines = File.ReadAllLines("Input.txt");

var score = 0;
var score2 = 0;
foreach(var line in lines)
{
    score += line[2] switch
    {
        'X' => 1,
        'Y' => 2,
        'Z' => 3,
        _ => 0
    };

    score += line switch
    {
        "A X" => 3,
        "B Y" => 3,
        "C Z" => 3,
        "A Y" => 6,
        "B Z" => 6,
        "C X" => 6,
        _ => 0
    };

    score2 += line[2] switch
    {
        'X' => 0,
        'Y' => 3,
        'Z' => 6,
        _ => 0
    };

    score2 += line switch
    {
        "A Y" => 1,
        "B X" => 1,
        "C Z" => 1,
        "A Z" => 2,
        "B Y" => 2,
        "C X" => 2,
        _ => 3
    };
}

Console.WriteLine(score);
Console.WriteLine(score2);