
Console.Clear();

string[] str1 = { "123e", "de", "dwedwed", "e23", "d"};
string[] str2 = new string [str1.Length];
PrintArray(str1);
FindArr(str1, str2);
PrintArray(str2);

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void FindArr(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
}

