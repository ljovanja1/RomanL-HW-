// Задача 21
// Напишите программу, которая принимает на вход координаты двух (трех) точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// AB^2 = (x2-x1)^2+(y2-y1)^2+(z2-z1)^2. 

Console.Write("Введиете координату по оси oX для второй точки ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введиете координату по оси oY для второй точки ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введиете координату по оси oZ для второй точки ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введиете координату по оси oX для первой точки ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введиете координату по оси oY для первой точки ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введиете координату по оси oZ для первой точки ");
int z1 = Convert.ToInt32(Console.ReadLine());

double d = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)),3); 
Console.WriteLine($"Расстояние: {d}");
