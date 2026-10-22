using System.Data.Common;

int energy = 55;

// TODO: Energy må være mellom 40 og 70, inklusive.
bool isStable = false;

if (energy > 40 && energy < 70)
{
    isStable = true;
}

/*
void Stable(int energy)
{
    
}*/
Console.WriteLine($"Reactor stable: {isStable}");
