int signalStrength = 72;

string status = "";

if (signalStrength >= 70)
{
    status = "STRONG";
}
else
{
    status = "WEAK";
}

Console.WriteLine($"Signal status: {status}");

/*
Console.WriteLine(status); // status finnes ikke her
*/

// TODO: Lag en løsning der status kan brukes etter if/else.
