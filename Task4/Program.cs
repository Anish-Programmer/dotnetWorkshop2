// 1. Create an integer array with 5 favorite numbers
int[] favNumbers = { 17, 5, 42, 11, 29 };

// 2. Sort in ascending order
Array.Sort(favNumbers);

// 3. Reverse the sorted array (now descending)
Array.Reverse(favNumbers);

// 4. Print each element using a for loop
Console.WriteLine("Array Elements:");
for (int i = 0; i < favNumbers.Length; i++)
{
    Console.WriteLine(favNumbers[i]);
}

// 5. Use Array.IndexOf() to find a specific number
int searchNumber = 42;
int index = Array.IndexOf(favNumbers, searchNumber);

Console.WriteLine($"\nIndex of {searchNumber}: {index}");