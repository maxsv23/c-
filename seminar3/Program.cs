//Задача 19 Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.

// Суть сравнить не числа а символы тоесть и буквы и аскиКоды пофигу что


        
Console.Write("input number  ");
string number = Convert.ToString(Console.ReadLine());

if (ExaminationPolindrom(number))
{
    Console.WriteLine("Полинром");
}
else
{
    Console.WriteLine("НЕ Полинром");
}




bool ExaminationPolindrom(string number)
        {

            for (int i = 0; i < number.Length / 2; i++)
            {
                if (number[i] != number[number.Length - i - 1])
                {
                    Console.WriteLine("не является полиндромом");
                    return false;
                }
            }
            return true;
        }


//Задача 21 Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.

Double x1, x2, y1, y2, z1, z2, distance;

Console.Write("x1: ");
x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("y1: ");
y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("z1: ");
z1 = Convert.ToDouble(Console.ReadLine());


Console.Write("x2: ");
x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("y2: ");
y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("z2: ");
z2 = Convert.ToDouble(Console.ReadLine());

distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine("distance " + distance);


//Задача 23 Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

// в задаче сказано ДО тоесть N брать в оборот не будем


Console.Write("input number ");
int number3 = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < number3; i++ ) {
    Console.WriteLine(Math.Pow(i , 3));
}

