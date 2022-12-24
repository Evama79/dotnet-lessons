/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/
namespace Sem4{
    class Task {
        
        public static double Task25(){
            Console.WriteLine("Введите число");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите натуральную степень");
            int n = Convert.ToInt32(Console.ReadLine());

            return Math.Pow(a, n);
        }


        public static double Task27(){
            Console.WriteLine("Введите число");
            double a = Convert.ToDouble(Console.ReadLine());

            char[] _buffer = a.ToString().ToCharArray();

            double sum = 0;

            foreach(char t in _buffer){
                sum += (Convert.ToInt32(t)-48);
            }
            return sum;

        }

        public static void Task29(){
            Console.WriteLine("Введите последовательность чисел через пробел или запятую");
            string[] a = Console.ReadLine().Split(new Char [] {',' , ' '});
            if(a.Length>8){
                Console.WriteLine("В массиве больше 8 элементов.");
                return;
            }

            a.ToList().ForEach(_t => Console.WriteLine(_t));

            // string.Join - объединяет элементы массива, в 1 аргументе - сепаратор
            Console.WriteLine("[{0}]", string.Join(",", a));
        }
        public static int Main(string[] args){
            // Task25();
            // Task27();
            // Task29();
        
            return 0;
        }
    }
}