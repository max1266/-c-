Console.Clear();
Console.WriteLine("Введите первое число");
double numberA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число");
double numberB = Convert.ToDouble(Console.ReadLine());
if (numberA > numberB){
    Console.Write("Максимальное число = ");
    Console.Write(numberA);
    Console.Write("Минимальное число = ");
    Console.Write(numberB);
}
else {
Console.Write("Максимальное число = ");
Console.Write(numberB);
Console.Write("Минимальное число = ");
Console.Write(numberA);
}
