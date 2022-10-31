// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();

Console.WriteLine("Введите число ");
int cube = Convert.ToInt32(Console.ReadLine());

  int i = 1;
  
  while (i < cube)
  {
    Console.WriteLine(Math.Pow(i,3));
    i++;
  }


