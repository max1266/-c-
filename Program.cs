//программа на определение четности числа
Console.Clear();
Console.WriteLine("Введите число");
double a = Convert.ToDouble(Console.ReadLine());
if (a%2 ==0){
    Console.WriteLine("да");
}
else {
    Console.WriteLine("Нет");
}
