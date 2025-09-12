//string mainString = "29535123p48723487597645723645";

Console.Write("Enter a string:");
string mainString = Console.ReadLine();
long sumOfAllSubstrings = 0;

for (int i = 0; i < mainString.Length; i++)
{
    int startIndex = i;
    int endIndex = -1;

    for (int ii = mainString.Length - 1; ii > i; ii--)
    {
        if (!char.IsDigit(mainString[ii]))
        {
            endIndex = -1;
        }
        else if (mainString[ii] == mainString[i])
        {
            endIndex = ii;
        }
    }

    if (endIndex != -1)
    {
        string start = mainString.Substring(0, startIndex);
        string middle = mainString.Substring(startIndex, endIndex - startIndex + 1);
        string end = mainString.Substring(endIndex + 1);

        sumOfAllSubstrings += Convert.ToInt64(middle);

        Console.Write($"{start}");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(middle);
        Console.ResetColor();
        Console.Write($"{end}\n");
    }
}

Console.WriteLine($"\nTotal sum of all substrings = {sumOfAllSubstrings}");