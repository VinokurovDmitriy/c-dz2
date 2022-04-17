// Программа выводит в консоль третью цифру числа или сообщает что ее нет в числе
int number = new Random().Next(-99999, 99999);
// int number = new Random().Next(-99, 99); //для теста двузначных чисел эту строку раскомментировать
int temp = number;
if (number < 0)
{
    temp = -number;
}
if (temp < 100)
{
    Console.WriteLine($"В числе {number} нет третьей цифры");
}
else
{
    while (temp > 999)
    {
        temp /= 10;
    }
    Console.WriteLine($"В числе {number}  третья цифра {temp % 10}");
}


