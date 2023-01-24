string[] arrayA = new string[6] {"I", "like", "geek",  "01", "brains", ":-)"};
string[] arrayB = new string[arrayA.Length];

SecondArrayWithIF(arrayA, arrayB);
PrintArray(arrayB);

void SecondArrayWithIF(string[] arrayA, string[] arrayB)
{
    int num = 0;
    for (int i = 0; i < arrayA.Length; i++)
    {
    if(arrayA[i].Length <= 3)
        {
        arrayB[num] = arrayA[i];
        num++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}