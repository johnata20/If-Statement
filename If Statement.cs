int order;
Console.WriteLine("These are all the available beverages:");
Console.WriteLine("1. Coke");
Console.WriteLine("2. Sprite");
Console.WriteLine("3. Royal Orange");
Console.WriteLine("4. Moutain Dew");
Console.WriteLine("5. Mineral Water");

Console.WriteLine();
Console.Write("Enter the number of your selection:");
order = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("You have selected:");

if (order == 1)
    Console.WriteLine("Coke");
if (order == 2)
    Console.WriteLine("Sprite");
if (order == 3)
    Console.WriteLine("Royal Orange");
if (order == 4)
    Console.WriteLine("Mountain Dew");
if (order == 5)
    Console.WriteLine("Mineral Water");

Console.WriteLine();
Console.WriteLine("Press any key to exit....");
Console.ReadLine();