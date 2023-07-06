// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
int copyNumber = number;
int num = number;
if (number != 0)
{
    while (number > 0)
    {
        count++;
        number = number / 10;
    }
}
else
{
    count++;
}
int[] array = new int[count];
for (int i = 0; i < count; i++)
{
    array[i]= copyNumber % 10;
    copyNumber = copyNumber/ 10;
}
int sum = array.Sum();
Console.WriteLine($"В числе {num} сумма чисел = {sum}");
