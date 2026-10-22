using System.Collections;

int cargoWeight = 800;
int maxWeight = 800;
int containerCount = 4;
int expectedContainers = 5;

// TODO: Erstatt false med riktige sammenligningsuttrykk.
bool isOverweight = false;
bool isExactlyAtLimit = false;
bool hasContainers = false;
bool countDiffersFromExpected = false;

if (cargoWeight >= maxWeight)
{
    isOverweight = true;
}
else if (cargoWeight == maxWeight)
{
    isExactlyAtLimit = true;
}
else if (containerCount >= 1)
{
    hasContainers = true;
}
else if (containerCount != expectedContainers)
{
    countDiffersFromExpected = true;
}

/*
switch (containerCount)
{
    case 1:

} */

Console.WriteLine($"Overweight: {isOverweight}");
Console.WriteLine($"Exactly at limit: {isExactlyAtLimit}");
Console.WriteLine($"Has containers: {hasContainers}");
Console.WriteLine($"Unexpected count: {countDiffersFromExpected}");
