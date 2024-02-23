# Метод по выводу массива на экран

void PrintArray(string[] arr)

{

    foreach (string e in arr)

    {

        Console.Write(e + " ");

    }

}

# Подсчет элементов нового массива

string[] array = { "Hello", "2", "world", ":-)" };

int j = 0;

for (int i = 0; i < array.Length; i++)

{

    if (array[i].Length <= 3)

        j++;

}

# Создание нового массива

string[] arr = new string[j];

# Заполнение нового массива

j = 0;

for (int i = 0; i < array.Length; i++)

{

    if (array[i].Length <= 3)

    {

        arr[j] = array[i];

        j++;

    }
}

# Вывод массива на экран через метод ***PrintArray***

PrintArray(arr);