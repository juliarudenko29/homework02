Console.Write("Введите трехзначное число: ");
    int value = Int32.Parse(Console.ReadLine());

    var countSymbols = Math.Floor(Math.Log10(value) + 1);

    if (countSymbols != 3)
    {
        Console.Write("Введите трехзначное число!");
        return;
    }

    int result;
    var temp = value;

    do
    {
        result = temp % 10;
        temp = temp / 10;
    } while (temp > 9);

    Console.WriteLine($"Вторая цифра слева числа {value} = {result}");
