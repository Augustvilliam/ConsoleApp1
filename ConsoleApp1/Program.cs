
string Yes = ("Y");
string No = ("N");
string yesno = ("");
Dictionary<string, double> items = new()
{
    {"1. Food", 2.99 },
    {"2. Drink", 1.49 },
    {"3 .Toilet papper", 0.99 },
    {"4. Cats", 50.00 },
    {"5. Crack-Cocain", 200.00 },
    {"6. A Cat on crack-Cocain", 75.00 },
    {"7. A cat on crack-cocain that also has a loaded gat", 150.00 },

};

List<string> shoppingList = [];
double totalCost = 0.0;

Console.WriteLine("its shopping time!");
Console.ReadKey();

do
{
    Console.WriteLine("Would you like to browse the available item? Press Y for yes, or N for no!");
    yesno = Console.ReadLine()?.ToUpper()!;


    if (string.IsNullOrEmpty(yesno))

    {
        Console.Clear();
        Console.WriteLine("please enter a valid input. Y for Yes or N for No!");

    }
    else if (yesno == Yes)
    {
        Console.Clear();
        Console.WriteLine("Here are the available itmes");
        foreach (var item in items)
        {
            Console.WriteLine($"{item.Key}-${item.Value:F2}");
        }

        Console.WriteLine("Enter the number of the item you wish to add to your shopping cart. Enter 0 to exit.");

        while (true)
        {
            Console.WriteLine("Your choice:");
            string input = Console.ReadLine()!;

            if (int.TryParse(input, out int choice) && choice >= 0 && choice <= items.Count)
            {
                if (choice == 0)
                {
                    Console.Clear();
                    Console.WriteLine("You have finished shopping.");
                    break;
                }
                string selectedItem = null!;
                int index = 1;
                foreach (var item in items)
                {
                    if (index == choice)
                    {
                        selectedItem = item.Key;
                        break;
                    }
                    index++;
                }

                if (selectedItem != null)
                { 
                

                shoppingList.Add(selectedItem);
                totalCost += items[selectedItem];
                Console.WriteLine($"'{selectedItem}' added to your shopping list. Current total is : ${totalCost:F2}");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid Choise. Please enter a valid number.");
                foreach (var item in items)
                {
                    Console.WriteLine($"{item.Key}-${item.Value:F2}");
                }
            }

        }
        break;
    }
    else if (yesno == No)
    {
        Console.Clear();
        Console.WriteLine("Okey. No cat for you then.");
        break;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("please enter a valid input. Y for Yes or N for No!");
    }
  
}
while (true);

if (shoppingList.Count > 0)
{
    Console.WriteLine("Your list containt the following items:");
    foreach (string item in shoppingList)
    {
        Console.WriteLine($"- {item}");
    }
    Console.WriteLine($"Total cost: ${totalCost:F2}");

    if (shoppingList.Contains("7. A cat on crack-cocain that also has a loaded gat"))
    {
        Console.Clear();
        Console.WriteLine("OY! Crack-cocain is illegal, having a gat is illegal, and giving a cat a gat AND crack-cocain certainly is illegal. Stop trying to buy it!");
        Console.WriteLine("                      ________________");
        Console.WriteLine("                      \\      __      /         __");
        Console.WriteLine("                       \\_____()_____/         /  )");
        Console.WriteLine("                       '============`        /  /");
        Console.WriteLine("                        #---\\  /---#        /  /");
        Console.WriteLine("                       (# @\\| |/@  #)      /  /");
        Console.WriteLine("                        \\   (_)   /       /  /");
        Console.WriteLine("                        |\\ '---` /|      /  /");
        Console.WriteLine("                _______/ \\\\_____// \\____/ o_|");
        Console.WriteLine("               /       \\  /     \\  /   / o_|");
        Console.WriteLine("              / |           o|        / o_| \\");
        Console.WriteLine("             /  |  _____     |       / /   \\ \\");
        Console.WriteLine("            /   |  |===|    o|      / /\\    \\ \\");
        Console.WriteLine("           |    |   \\@/      |     / /  \\    \\ \\");
        Console.WriteLine("           |    |___________o|__/----)   \\    \\/");
        Console.WriteLine("           |    '              ||  --)    \\     |");
        Console.WriteLine("           |___________________||  --)     \\    /");
        Console.WriteLine("                |           o|   ''''   |   \\__/");
        Console.WriteLine("                |            |          |");
        Console.WriteLine("");
        Console.WriteLine("                        CAPTAIN NARC");
    }
}
else
{
    Console.WriteLine("You did not add any items to your shopping list.");
}

