Console.WriteLine("Введите элементы массива, разделяя их пробелом:");
string input = Console.ReadLine();

string[] inputArray = input.Split(' ');
string[] resultArray = FilterArray(inputArray);

Console.WriteLine("Результат:");
foreach (string str in resultArray)
{
    Console.WriteLine(str);
}

string[] FilterArray(string[] inputArray)
{
    int count = 0;

    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            count++;
        }
    }

    string[] result = new string[count];
    int index = 0;


    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            result[index] = inputArray[i];
            index++;
        }
    }

    return result;
}
