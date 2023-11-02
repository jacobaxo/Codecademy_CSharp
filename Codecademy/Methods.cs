using System;

static void Main(string[] args)
{
    Console.WriteLine("What monument would you like to work with?( TAJ MAHAL or AL HARAM )");
    string answer = Console.ReadLine();
    answer = answer.ToUpper();

    switch (answer)
    {

        case "TAJ MAHAL":
            CalculateTotalCost(answer);
            break;

        case "AL HARAM":
            CalculateTotalCost(answer);
            break;

        default:
            Console.WriteLine("Error, please restart the program");
            break;

    }
}
static double CalculateTotalCost(string Building)
{
    switch (Building)
    {
        case "TAJ MAHAL":
            double triArea = 24 * 24 * 2 * 4;
            double totalArea = 90.5 * 90.5 - triArea;
            double price = totalArea * 180;
            Console.WriteLine($"{price} poses");
            return price;


        case "AL HARAM":
            double triArea2 = 264 * 84 / 2;
            double bigRectArea = 284 * 264 - triArea2;
            double smallRectArea = 180 * 106;
            double totalArea2 = bigRectArea + smallRectArea;
            double price2 = totalArea2 * 180;
            Console.WriteLine($"{price2} poses");
            return price2;



        default:
            Console.WriteLine("error");
            return 0;
    }
}