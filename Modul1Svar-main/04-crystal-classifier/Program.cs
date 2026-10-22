int energy = 52;
string classification = "";

// TODO: Sett classification med if / else if / else.

if (energy < 20)
{
    classification = "Dormant";
}
else if (energy >= 49 && energy > 20)
{
    classification = "Stable";
}
else if (energy > 50 && energy <= 79)
{
    classification = "Unstable";
}
else if (energy >= 80)
{
    classification = "Critical";
}
else
{
    Console.WriteLine("Unknown radioactivity levels");
}

Console.WriteLine($"Classification: {classification}");
