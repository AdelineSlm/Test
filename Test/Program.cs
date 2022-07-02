Console.Clear();
// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
string[] InputArray(int length)
{
    string[] tempArray = new string[length];
    for (int i = 0; i < length; i++) {
        Console.Write($"Введите {i + 1} элемент массива: ");
        tempArray[i] = (Console.ReadLine() ?? "");
    }
    return tempArray;
}
string[] NewArray(string[] initialArray)
{
    int j = 0;
    for (int i = 0; i < initialArray.Length; i++) {
        if (initialArray[i].Length <= 3) 
            j++;
    }

    string[] tempArray = new string[j]; 
    j = 0;
    for (int i = 0; i < initialArray.Length; i++) {
        if (initialArray[i].Length <= 3)
        {
            tempArray[j] = initialArray[i];
            j++;
        }
    }
    return tempArray;
}
string PrintArray(string[] array)
{
    int length = array.Length;
    string temp = "[";
    for (int i = 0; i < length; i++) {
        if (i < length - 1)
            temp = temp + $"'{array[i]}', ";
        else temp = temp + $"'{array[i]}'";
    }
    temp = temp + "]";
    return temp;
}

Console.Write("Введите длину массива строк: ");
string length = (Console.ReadLine() ?? "");
int securedLength = int.Parse(length);
string[] initArray = InputArray(securedLength);
string[] finalArray = NewArray(initArray);
Console.WriteLine();
Console.WriteLine("Введенный массив:");
Console.WriteLine(PrintArray(initArray));
Console.WriteLine();
Console.WriteLine("Сформированный массив из строк начального массива, длина которых меньше либо равна 3 символа:");
Console.WriteLine(PrintArray(finalArray));
Console.WriteLine();

