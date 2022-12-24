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
                Console.WriteLine("Введите число"); 
                var a = Console.ReadLine();
                char[] digits = a.ToString().ToCharArray();
                if(digits.Length < 3)
                {
                    Console.WriteLine("У введенного числа нет третьего символа");
                }
                Console.WriteLine(digits[2]);
        }
    }
}


