Console.Clear();
Console.WriteLine("Введите первое число");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите третье число");
double c = Convert.ToDouble(Console.ReadLine());
double max = a ;
if (a > max)
    max = a;
if (b > max)
    max = b;
    else
        max = a;
if (c > max)
    max = c;
Console.WriteLine(max);
