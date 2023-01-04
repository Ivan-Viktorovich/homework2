// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (a >= 100 && a <= 999)
{
    a = (a / 1) % 10;
    Console.WriteLine("Третье число " + a);
}
else if (a >= 1000 && a <= 99999)
{
    a = (a / 100) % 10;
    Console.WriteLine("Третье число " + a);
}

else if (a >= 1 && a <= 99)
{
    Console.WriteLine("Двузначное не подходит:)");
}
else
{
    Console.WriteLine("Введите другое число");
}