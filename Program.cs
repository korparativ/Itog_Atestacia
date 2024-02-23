void PrintArray(string[] arr)
{
    foreach (string e in arr)
    {
        Console.Write(e + " ");
    }
}

string[] array = { "Hello", "2", "world", ":-)" };
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
        j++;
}
string[] arr = new string[j];