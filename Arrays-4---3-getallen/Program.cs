try
{
    const int NumberOfNumbers = 3;

    Console.WriteLine($"==== Som bepalen van {NumberOfNumbers} getallen ====\r\n\r\n");
    int[] numbers = new int[NumberOfNumbers];

    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"Geef getal {i + 1}/{NumberOfNumbers} : ");
        numbers[i] = int.Parse(Console.ReadLine());
        Console.WriteLine();
    }

    int sum = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }

    //foreach (int number in numbers)
    //    sum += number;

    Console.WriteLine($"\r\nDe som is {sum}");
    Console.ReadLine();
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine($"Index bestaat niet!!!");
    Console.ReadLine();
}
