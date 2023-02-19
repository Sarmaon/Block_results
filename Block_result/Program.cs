// Задача: Написать программу, которая из меющего  массива строк формируем массив из строк, длина которых меньше либо равна 3 симвоволам. Первоначальный массив можно ввесли с клавиатуры,
// либо задать на старте выполнения алгоритма.

string[] mainString = MainStringArray();
PrintArray(mainString);
Console.WriteLine(" ");
int count = CountNewLenght(mainString);
string[] newString = NewStringArray(mainString, count);
PrintArray(newString);

string[] MainStringArray()
{
    string[] arrayString = new string [] {"RHBZ", "SU35", "RPG", "+", "T90", "RVSN", "Army"};
    return arrayString;
}

int CountNewLenght(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count += 1;
    }
    return count;
}

string[] NewStringArray(string[]array, int lenght)
{
    string[] newStringArray = new string[lenght];
    int j =0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newStringArray[j] = array[i];
            j++;
        }
    }
    return newStringArray;
}

void PrintArray(string[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.Write(" ]");
}