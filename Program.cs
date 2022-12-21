//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

Console.Write("input number");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input number");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2) {
    Console.WriteLine("number1 = number2");
}
else if (number1 > number2)
{
    Console.WriteLine(number1 + " > " + number2);
}
else Console.WriteLine(number1 + " < " + number2);



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("input number1");
int number41 = Convert.ToInt32(Console.ReadLine());
Console.Write("input number2");
int number42 = Convert.ToInt32(Console.ReadLine());
Console.Write("input number3");
int number43 = Convert.ToInt32(Console.ReadLine());

int max= number41;
if (max < number42) max = number42;
if (max < number43) max = number43;

Console.WriteLine("maximum number " + max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("input number");
int number61 = Convert.ToInt32(Console.ReadLine());
if (number61%2 == 0) Console.WriteLine("число четное");
else Console.WriteLine("число не четное");

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("input number");
int number81 = Convert.ToInt32(Console.ReadLine());
string str = "";

for (int i=1; i<number81; i++)
{
if (i%2 == 0) str = str + " " + i;
}

Console.WriteLine(str);