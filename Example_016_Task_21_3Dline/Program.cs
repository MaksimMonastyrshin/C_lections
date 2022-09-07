// Задача 21: Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// А (3,6,8); В(2,1,-7) -> 15.84
// А (7,-5,0); В(1,-1,9) -> 11.53

Console.WriteLine("Введите координату Х точки А: ");
double ax = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y точки А: ");
double ay = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z точки А: ");
double az = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату Х точки B: ");
double bx = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B: ");
double by = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z точки B: ");
double bz = Convert.ToDouble(Console.ReadLine());

double d = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az), 2));

Console.WriteLine($"A({ax},{ay},{az}); B({bx},{by},{bz}) -> {d}");
