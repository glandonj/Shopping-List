using System;

Dictionary<string, decimal> menu = new Dictionary<string, decimal>();
menu.Add("milk", 3.99m);
menu.Add("bread", 3.50m);
menu.Add("bag of apples", 4.89m);
menu.Add("eggs", 6.15m);
menu.Add("jelly beans", 0.99m);
menu.Add("peanut butter", 5.50m);
menu.Add("jam", 2.70m);
menu.Add("cheese", 10.00m);

Console.WriteLine("Welcome to our humble store.\n\nPlease see the list of items we sell here:\n");
Console.WriteLine(String.Format("{0,-15} {1,-15}", "Item", "Price"));
Console.WriteLine(String.Format("{0,-15} {1,-15}", "======", "======"));

foreach (KeyValuePair<string, decimal> kvp in menu)
{
    Console.WriteLine(String.Format("{0,-15} {1,-15}",$"{kvp.Key}", $"${kvp.Value}"));
}

List<string> order = new List<string>();
while (true)
{
    Console.Write("\nEnter an item name: ");
    string item = Console.ReadLine().ToLower().Trim();

    if (menu.ContainsKey(item))
    {
        decimal cost = menu[item];
        order.Add(item);
        Console.WriteLine($"{item} is ${cost}.");
        while (true)
        {
            Console.WriteLine($"Do you want to add another {item} to your order? y/n");
            string response = Console.ReadLine();
            if (response == "n" || response == "no")
            {
                break;
            }
            else if (response == "y" || response == "yes")
            {
                order.Add(item);
            }
            else
            {
                Console.WriteLine("Invalid entry.");
            }
        }
            Console.WriteLine("Would you like to add anything else to your order (y/n)?");
            string answer = Console.ReadLine();
            if (answer == "n" || answer == "no")
            {
                break;
            }
            else if (answer == "y" || answer == "yes")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid entry.");
            }
        }

    else
    {
        Console.WriteLine("Sorry, we do not have that item. Please try again.");
    }

}
Console.WriteLine("\nHere is your receipt:");
Console.WriteLine(String.Format("{0,-15} {1,-15}", "Item", "Price"));
Console.WriteLine(String.Format("{0,-15} {1,-15}", "======", "======"));
decimal total = 0;
foreach (string i in order)
{
    Console.WriteLine(String.Format("{0,-15} {1,-15}", $"{i}", $"${menu[i]}"));
    total += menu[i];
}
Console.WriteLine($"\nYour total is ${total}.");


Console.WriteLine("\nGoodbye!");





