/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую
цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
namespace task_1 
{
    class Task
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 99 && a < 1000)
            {
                //8 5 1
                Console.WriteLine((a % 100 / 10));
            }
            else
            {
                Console.WriteLine("Неправильное число");
            }    
        } 
    }
}