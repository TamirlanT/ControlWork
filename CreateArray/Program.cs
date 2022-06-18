Console.WriteLine("Создание массива...");

string [] massive = {"Sun", "Month", "Moscow", "2A", "Location", "G"};
for (int i = 0; i < massive.Length; i++)
Console.WriteLine(massive[i]);

int resultArrayLength = 0;
for (int index = 0; index < massive.Length; index++)
{
    if (massive[index].Length <= 3)
    {
        resultArrayLength++;
    }
}
Console.WriteLine();
Console.WriteLine("Результат:");
Console.WriteLine();
string [] resultStringArray = new string [resultArrayLength];
for (int index = 0, resultindex = 0; index < massive.Length; index++)
{
    if (massive[index].Length <=3)
    {
        resultStringArray[resultindex] = massive[index];
        Console.WriteLine(resultStringArray[resultindex]);
    }
}