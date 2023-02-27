string[] SourceArray = new string[5] {"Kazan", "Ork", "World", "Soul", "res"};
string[] FilteredArray = new string[SourceArray.Length];

void FilterArrayByLength(string[] SourceArray, string[] filteredArray)
{
    int count = 0;
    for (int i = 0; i < SourceArray.Length; i++)
    {
        if (SourceArray[i].Length <= 3)
        {
            filteredArray[count] = SourceArray[i];
            count++;
        }
    }
}

void PrintArray(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]} ");
    }
    Console.WriteLine();
}


FilterArrayByLength(SourceArray, FilteredArray);
PrintArray(FilteredArray);