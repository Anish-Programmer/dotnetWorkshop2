// Declare & initialize variables
byte b = 10;
short s = 200;
int i = 1000;
long l = 50000L;
float f = 3.5f;
double d = 9.81;
decimal dec = 100.55m;
char ch = 'A';
bool flag = true;

// Convert integer 42 to string
string strNumber = 42.ToString();

// Convert string "3.14" to double
double pi = double.Parse("3.14");

// Print all variables
Console.WriteLine("byte: " + b);
Console.WriteLine("short: " + s);
Console.WriteLine("int: " + i);
Console.WriteLine("long: " + l);
Console.WriteLine("float: " + f);
Console.WriteLine("double: " + d);
Console.WriteLine("decimal: " + dec);
Console.WriteLine("char: " + ch);
Console.WriteLine("bool: " + flag);
Console.WriteLine("Converted int to string: " + strNumber);
Console.WriteLine("Converted string to double: " + pi);

