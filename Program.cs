string[] sourceArray = new string[5] {"Kazan", "Ork", "World", "Soul", "res"};
string[] filteredArray = new string[sourceArray.Length];

void FilterArrayByLength(string[] sourceArray, string[] filteredArray)
{
    int count = 0;
    for (int i = 0; i < sourceArray.Length; i++)
    {
        if (sourceArray[i].Length <= 3)
        {
            filteredArray[count] = sourceArray[i];
            count++;
        }
    }
}

FilterArrayByLength(sourceArray, filteredArray);
PrintArray(filteredArray);