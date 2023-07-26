void CounterNumsAboveZero(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) counter++;
    }
    Console.Write(counter);
}

int[] GetArray(string nums)
{
    string[] inputNums = nums.Split(' ');
    int[] array = new int[inputNums.Length];
    for (int i = 0; i < inputNums.Length; i++)
    {
        int.TryParse(inputNums[i], out array[i]);
    }
    return array;
}

string GetInput(string text)
{
    Console.Write(text);
    return (Console.ReadLine());
}

string nums = GetInput("Введите числа через пробел: ");
int[] array = GetArray(nums);
Console.Write($"{String.Join(", ",GetArray(nums))} -> ");
CounterNumsAboveZero(array);