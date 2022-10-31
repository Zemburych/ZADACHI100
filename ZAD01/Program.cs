// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();

Console.Write("Введите число: ");
string number = Console.ReadLine();
if (number!.Length == 5)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Число: {number} - палиндром.");
  }
  else Console.WriteLine($"Число: {number} - НЕ палиндром.");
}
else
{
Console.WriteLine($"неправильное число");
}