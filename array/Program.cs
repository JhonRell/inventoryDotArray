string[] ordersIDs = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

foreach(string ordersID in ordersIDs)
{
    if(ordersID.StartsWith('B'))
    {
        Console.WriteLine($"Fraudulent Order ID: {ordersID}");
    }
}

/* int[] inventory = {200, 450, 700, 175, 250};
int sum = 0;
int bin = 0;
foreach(int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have the {sum} items in the inventory."); */