 Console.Write("Введите день недели (1-7): ");
int value = Int32.Parse(Console.ReadLine());

    if (value < 1 || value > 7)
    {
        Console.WriteLine("Введите цифру от 1 до 7");
        return;
    }

    var isDayOff = (value == 6 || value == 7);
    var resultStr = isDayOff ? "выходной день" : "будний день";
    Console.WriteLine($"день недели {value} = {resultStr}");
