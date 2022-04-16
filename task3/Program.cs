// Программа выводит в консоль третью цифру числа или сообщает что ее нет в числе
int number = new Random().Next(10,1000);
if(number  > 99){
    Console.WriteLine($"В числе {number}  третья цифра {number%10}");
} else {
    Console.WriteLine($"В числе {number} нет третьей цифры");
}
