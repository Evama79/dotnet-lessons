/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3

Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

namespace Sem5{
    class Task{

        public static void Task41(){
            Console.WriteLine("Введите последовательность чисел через пробел или запятую");
            string[] a = Console.ReadLine().Split(new Char [] {',' , ' '});
            if(a.Length>8){
                Console.WriteLine("В массиве больше 8 элементов.");
                return;
            }

            int counter = 0;

            a.ToList().ForEach(_t => {
                if(Convert.ToInt32(_t) > 0) {
                    counter += 1;
                }
            });
            // a.ToList().ForEach(_t => counter += Convert.ToInt32(_t)>0 ? 1 : 0);
            
            Console.WriteLine("Количество чисел больше нуля: {0}", counter);
        }

        public static void Task43(){
            //double a1, b1, a2, b2, x, y;
            double b1 = Convert.ToDouble(Console.ReadLine());
            double k1 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double k2 = Convert.ToDouble(Console.ReadLine());
            
            double x = (b2-b1)/(k1-k2);
            double y = k2*(b2-b1)/(k1-k2) + b2;

            Console.WriteLine("{0}, {0}", x, y);
            

        }

        public static int Main(string[] args){
            Task43();
            return 1;
        }
    }
}