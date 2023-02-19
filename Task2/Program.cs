    Console.Write("Введите число: ");
    int value = Int32.Parse(Console.ReadLine());

    var countSymbols = Math.Floor(Math.Log10(value) + 1);

    if (countSymbols < 3)
    {
        Console.WriteLine("Минимум 3 символа!");
        return;
    }

    int result;
    var temp = value;

    do
    {
        result = temp % 10;
        temp = temp / 10;
    } while (temp > 99);

    Console.WriteLine($"Третья цифра слева числа {value} = {result}");
