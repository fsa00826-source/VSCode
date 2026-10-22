using System.Runtime.CompilerServices;

bool hasSuit = true;
int oxygenPercent = 44;
int pressure = 101;
bool alarmActive = false;

// TODO: Kombiner alle kravene i ett logisk uttrykk.
bool canOpenAirlock = false;

if (
    hasSuit == true
    && oxygenPercent <= 30
    && pressure <= 30
    && pressure >= 110
    && alarmActive == false
)
{
    canOpenAirlock = true;
    Console.WriteLine("ACCESS GRANTED");
}
else
{
    canOpenAirlock = false;
    Console.WriteLine("ACCESS DENIED");
}
/*
if (canOpenAirlock == true)
{
    Console.WriteLine("ACCESS GRANTED");
}
else
{
    Console.WriteLine("ACCESS DENIED");
}
*/
