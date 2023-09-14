string txt;
do
{
    Console.WriteLine("Какой цвет вы любите?");
    Console.WriteLine("1. Черный");
    Console.WriteLine("2. Красный");
    Console.WriteLine("3. Фиолетовый");
    Console.WriteLine("4. Белый");
    Console.WriteLine("5. никакой((((");
    txt = Console.ReadLine();

    switch (txt)
    {
        case "1":
            Console.WriteLine("sdfsdfsd");
            break;
        case "2":
            break;
        case "3":
            break;
        case "4":
            break;
        case "5":
            Console.WriteLine("ну и ладно");
            break;
        default:
            Console.WriteLine("такого цвета не придумали");
            break;
    }
} while (txt != "5");