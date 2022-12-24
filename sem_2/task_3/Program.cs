/*
Задача 13: Напишите программу, которая выводит третью цифру заданного 
числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
namespace task_3
{
    class Task
    {
            
            public static void Main(string[] args)
        {
                Console.WriteLine("Введите номер дня недели"); 
                int a = Convert.ToInt32(Console.ReadLine());
                if (a < 1 || a > 7)
                {
                    Console.WriteLine("It's not a day of the week");
                }
                else
                {
                    if (a == 6 || a == 7)
                    {
                        Console.WriteLine("Day off");
                    }
                    else
                    {
                        Console.WriteLine("Work day");
                    }
                }
                 
        }
    }
}

