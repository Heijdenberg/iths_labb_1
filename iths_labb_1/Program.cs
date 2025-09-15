//"29535123p48723487597645723645";
Console.Write("Enter a string:");
string mainString = Console.ReadLine();
long sumOfAllSubstrings = 0;

for (int i = 0; i < mainString.Length; i++)
{
    int endIndex = -1;

    for (int ii = mainString.Length - 1; ii > i; ii--)
    {
        if (mainString[ii] == mainString[i])
        {
            endIndex = ii;
        }
    }

    if (endIndex != -1 && Int64.TryParse(mainString.Substring(i, endIndex - i + 1), out long substring))
    {
        sumOfAllSubstrings += substring;

        Console.Write(mainString.Substring(0, i));
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(substring);
        Console.ResetColor();
        Console.WriteLine(mainString.Substring(endIndex + 1));
    }
}

Console.WriteLine($"\nTotal sum of all substrings = {sumOfAllSubstrings}");