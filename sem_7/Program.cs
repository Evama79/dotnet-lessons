/*
Урок 7. Двумерные массивы
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9

Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет

Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

namespace Ns1 {

    class Task {
        static int _X_DIMENSION = 3;
        static int _Y_DIMENSION = 4;

        public static double[,] RandomDoubleMatrix(int m, int n) {
            double[,] mtx = new double[m, n];
            Random rnd = new Random();

            for(int i =0; i< m; i++) {
                for(int j = 0; j < n;  j++){
                    mtx[i,j] = rnd.NextDouble() * Convert.ToDouble(rnd.NextInt64(1, 10));
                }
            }
            return mtx;
        }
         public static long[,] RandomIntMatrix(int m, int n) {
            long[,] mtx = new long[m, n];
            Random rnd = new Random();

            for(int i =0; i< m; i++) {
                for(int j = 0; j < n;  j++){
                    mtx[i,j] = rnd.NextInt64(1, 10);
                }
            }
            return mtx;
        }

        static void PrintMatrix(double[,] mtx, int m, int n) {
            for(int i =0; i< m; i++) {
                for(int j = 0; j < n;  j++){
                    System.Console.Write("{0}\t", mtx[i,j]);
                }
                System.Console.WriteLine();
            }
        }
        static void PrintMatrix(long[,] mtx, int m, int n) {
            for(int i =0; i< m; i++) {
                for(int j = 0; j < n;  j++){
                    System.Console.Write("{0}\t", mtx[i,j]);
                }
                System.Console.WriteLine();
            }
        }

        static void FindByIndex(double[,] mtx, int index) {
            int y_index = index > 10 ? index / 10 : 0;
            int x_index = index > 10 ? index % 10 : index;
            System.Console.WriteLine("Current X and Y index: {0}, {1}", x_index, y_index);

            try {
                System.Console.WriteLine("Element at position ({0}, {1}): {2}", x_index, y_index, mtx[x_index, y_index]);
            }
            catch(Exception e) {
                System.Console.WriteLine(e.Message);
            }
        }
        static void AverageByColumn(long[,] mtx, int x_size, int y_size) {
            double[] average = new double[y_size];

            for(int i=0; i<y_size; i++) {
                for(int j = 0; j < x_size; j++){
                    average[i] += mtx[j,i];
                }
                average[i] /= x_size;
                System.Console.WriteLine("DEBUG: current average: {0}", average[i]);
            }
        }

        public static void Main(string[] args) {
            // Задачи 47 + 50
            // double[,] mtx = RandomDoubleMatrix(_X_DIMENSION, _Y_DIMENSION);
            // PrintMatrix(mtx, _X_DIMENSION, _Y_DIMENSION);
            // FindByIndex(mtx, 32);

            // Задача 52
            // long[,] intMtx = RandomIntMatrix(_X_DIMENSION, _Y_DIMENSION);
            // PrintMatrix(intMtx, _X_DIMENSION,_Y_DIMENSION);
            // AverageByColumn(intMtx, _X_DIMENSION, _Y_DIMENSION);
        }
    }
}
