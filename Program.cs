/*
// sbyte
int min = -128;
int max = 127;
string type = "sbyte";
System.Console.WriteLine("Plese, Enter number");
long num = long.Parse(Console.ReadLine());
if (min < num && num < max) // верное выражение
{
sbyte transform = (sbyte) num;
System.Console.WriteLine($"Число {transform} успешно приобразованно в тип {type}!");
}
else // вывод ошибки
{
System.Console.WriteLine($"Для приведения числа {num} к типу {type} число не может быть больше {max} и меньше {min}!");
}


// short
int min = -32768;
int max = 32767;
string type = "short";
System.Console.WriteLine("Plese, Enter number");
long num = long.Parse(Console.ReadLine());
if (min < num && num < max) // верное выражение
{
short transform = (short) num;
System.Console.WriteLine($"Число {transform} успешно приобразованно в тип {type}!");
}
else // вывод ошибки
{
System.Console.WriteLine($"Для приведения числа {num} к типу {type} число не может быть больше {max} и меньше {min}!");
}


// int
int min = -2147483648;
int max = 2147483647;
string type = "int";
System.Console.WriteLine("Plese, Enter number");
long num = long.Parse(Console.ReadLine());
if (min < num && num < max) // верное выражение
{
int transform = (int) num;
System.Console.WriteLine($"Число {transform} успешно приобразованно в тип {type}!");
}
else // вывод ошибки
{
System.Console.WriteLine($"Для приведения числа {num} к типу {type} число не может быть больше {max} и меньше {min}!");
}


// byte
int min = 0;
int max = 255;
string type = "byte";
System.Console.WriteLine("Plese, Enter number");
long num = long.Parse(Console.ReadLine());
if (min < num && num < max) // верное выражение
{
byte transform = (byte) num;
System.Console.WriteLine($"Число {transform} успешно приобразованно в тип {type}!");
}
else // вывод ошибки
{
System.Console.WriteLine($"Для приведения числа {num} к типу {type} число не может быть больше {max} и меньше {min}!");
}


// ushort
int min = 0;
int max = 65535;
string type = "ushort";
System.Console.WriteLine("Plese, Enter number");
long num = long.Parse(Console.ReadLine());
if (min < num && num < max) // верное выражение
{
ushort transform = (ushort) num;
System.Console.WriteLine($"Число {transform} успешно приобразованно в тип {type}!");
}
else // вывод ошибки
{
System.Console.WriteLine($"Для приведения числа {num} к типу {type} число не может быть больше {max} и меньше {min}!");
}



// uint
uint min = 0;
uint max = 4294967295;
string type = "uint";
System.Console.WriteLine("Plese, Enter number");
long num = long.Parse(Console.ReadLine());
if (min < num && num < max) // верное выражение
{
uint transform = (uint) num;
System.Console.WriteLine($"Число {transform} успешно приобразованно в тип {type}!");
}
else // вывод ошибки
{
System.Console.WriteLine($"Для приведения числа {num} к типу {type} число не может быть больше {max} и меньше {min}!");
}


// ulong
ulong min = 0;
ulong max = 9223372036854775807;
string type = "ulong";
System.Console.WriteLine("Plese, Enter number");
ulong num = ulong.Parse(Console.ReadLine());
if (min < num && num < max) // верное выражение
{
ulong transform = (ulong) num;
System.Console.WriteLine($"Число {transform} успешно приобразованно в тип {type}!");
}
else // вывод ошибки
{
System.Console.WriteLine($"Для приведения числа {num} к типу {type} число не может быть больше {max} и меньше {min}!");
}
*/

// long
long min = -9223372036854775808;
long max = 9223372036854775807;
string type = "long";
System.Console.WriteLine("Plese, Enter number");
long num = long.Parse(Console.ReadLine());
if (min < num && num < max) // верное выражение
{
long transform = (long) num;
System.Console.WriteLine($"Число {transform} успешно приобразованно в тип {type}!");
}
else // вывод ошибки
{
System.Console.WriteLine($"Для приведения числа {num} к типу {type} число не может быть больше {max} и меньше {min}!");
}