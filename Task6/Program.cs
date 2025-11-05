//Generic Collections(List and Dictionary)

// 1. Create a List<string> with 3 favorite fruits
List<string> fruits = new List<string>() { "Apple", "Orange", "Coconut" };

// 2. Add a new fruit
fruits.Add("Mango");

// 3. Remove one fruit
fruits.Remove("Apple");

// 4. Print all fruits using foreach
Console.WriteLine("Fruits in the List:");
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}

// 5. Create a Dictionary<int, string> with fruit IDs
Dictionary<int, string> fruitDict = new Dictionary<int, string>()
        {
            {1, "Mango"},
            {2, "Banana"},
            {3, "Orange"}
        };

// 6. Add a new entry
fruitDict.Add(4, "Pineapple");

// 7. Print all key-value pairs
Console.WriteLine("\nFruit Dictionary:");
foreach (var item in fruitDict)
{
    Console.WriteLine($"ID: {item.Key}, Fruit: {item.Value}");
}