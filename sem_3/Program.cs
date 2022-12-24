/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да

Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53

Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

using System;
namespace Seminar3 {
    public class Task {
        public static bool Task19(){
            /*
            Сравнение чисел по индексам: если число [i] != [Length - 1 - i] - не палиндром
            */
            Console.WriteLine("Введите значение для проверки на палиндромность: ");
            char[] a = Console.ReadLine().ToCharArray();

            for(int i=0; i<a.Length/2; i++){
                if(a[i] != a[a.Length-1-i]){
                    Console.WriteLine("Не палиндром: " + a[i] + " не равно " + a[a.Length-1-i]);
                    return false;
                }
            }
            Console.WriteLine("Палиндром");
            return true;
        }

        public static void Task21(int[] a, int[] b){
            if(a.Length != b.Length) {
                Console.WriteLine("Точки не совпадают по количеству измерений");
                return;
            }

            double squareDistance = 0;
            for(int i=0; i<a.Length; i++){
                squareDistance += Math.Pow((a[i]-b[i]), 2);
            }

            Console.WriteLine(Math.Sqrt(squareDistance));
        }

        public static void Task23(int n){
            //sConsole.WriteLine("Debug: t23 entered");
            for(int i=1; i <= n; i++){
                Console.WriteLine(Math.Pow(i, 3));
            }
        }

        public static int Main(string[] args){
            // Раскомментируй, чтобы вызвать функции для задач

            // Задача 19
            //Task19();
            
            // Задача 21
            int[] a = {3,6,8, 2}; int[] b = {2,1,-7, 7};
             Task21(a, b);
            
            // Задача 23
            // Task23(3);
            
            return 1;

        }
    }
}