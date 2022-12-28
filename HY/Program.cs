
/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет,
 является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/
bool MethodP (int Number)
{
int current1 = 1;
int current2 = 1;
int current3 = 1;
int current4 = 1;

current1 = Number / 10000;
current2 = Number % 10;
current3 = Number / 1000 % 10;
current4 = Number % 100 /10;

if(current1 == current2 && current3 == current4 )
{
    return true;
}
else
{
   return false;
}
}

Console.WriteLine("Vvedite piatiznachnoe chislo  (Number)");

int Number = Convert.ToInt32(Console.ReadLine());
if(MethodP (int Number))
{
    Console.WriteLine("Da");
}
else
{
    Console.WriteLine("Net");
}


/*Задача 21Напишите программу, которая принимает на вход координаты двух точек и находит
 расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/
double Dist(double x1,double y1,double z1,
                double x2,double y2,double z2)
{
    double res1 = Math.Pow(x2 - x1, 2);
    double res2 = Math.Pow(y2 - y1, 2);
    double res3 = Math.Pow(z2 - z1, 2); 
    double resalt = Math.Sqrt(res1 + res2 +res3);
    return resalt; 
}
Console.Write("Введите координаты первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Расcтояние между точками:" + Dist(x1,y1,z1,x2,y2,z2));

/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/
void Cube (int n)
{
    int count = 1;
    Console.WriteLine("Квадраты чисел:"  );
    while(count < n+1)
    {
        Console.Write(count * count * count + " ");
        count = count + 1;

    }
}


Console.Write("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
Cube ( n );

