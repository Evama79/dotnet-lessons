/*
Урок 8. Двумерные массивы. Продолжение
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

using System.Linq;
namespace Ns1 {
    class Direction {
        public string Left = "left";
        public string Right = "right";
        public string Up = "up";
        public string Down = "down";
    }

    class Task {
        static int _X_DIMENSION = 2;
        static int _Y_DIMENSION = 2;
        static int _Z_DIMENSION = 3;
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
        static void PrintMatrix(long[,] mtx) {
            System.Console.WriteLine("Current matrix:");
            for(int i =0; i< mtx.GetLength(0); i++) {
                for(int j = 0; j < mtx.GetLength(1);  j++){
                    System.Console.Write("{0}\t", mtx[i,j]);
                }
                System.Console.WriteLine();
            }
        }

        public static long[,] SortByRow(long [,] intArray) {
            for(int k = 0; k < _X_DIMENSION; k ++){
                for (int i = 0; i <= _Y_DIMENSION-1; i++)  
                {  
                    for (int j = i+1; j < _Y_DIMENSION; j++)  
                    {  
                        if (intArray[k,i] > intArray[k,j])  
                        {  
                            long temp = intArray[k,i];  
                            intArray[k,i] = intArray[k,j];  
                            intArray[k,j] = temp;  
                        }  
                    }  
                } 
            }
            return intArray;
        }

        static long MaxByRow(long[,] mtx) {
            long[] rowSum = new long[_Y_DIMENSION];

            for(int i=0; i<_X_DIMENSION; i++) {
                for(int j = 0; j < _Y_DIMENSION; j++){
                    rowSum[i] += mtx[i,j];
                }
                System.Console.WriteLine("DEBUG: Current row sum: {0}", rowSum[i]);
            }
            System.Console.WriteLine("Row with max sum value: {0}", rowSum.Max());
            return (long)rowSum.Max();
        }
        static long[,] MultiplyMatrix(long[,] A, long[,] B)
        {
            int rA = A.GetLength(0);
            int cA = A.GetLength(1);
            int rB = B.GetLength(0);
            int cB = B.GetLength(1);

            if (cA != rB)
            {
                Console.WriteLine("Matrixes can't be multiplied!!");
                return A;
            }
            else
            {
                long temp = 0;
                long[,] der = new long[rA, cB];

                for (int i = 0; i < rA; i++)
                {
                    for (int j = 0; j < cB; j++)
                    {
                        temp = 0;
                        for (int k = 0; k < cA; k++)
                        {
                            temp += A[i, k] * B[k, j];
                        }
                        der[i, j] = temp;
                    }
                }
                return der;
            }
        }

        public static long[,,] Random3dIntMatrix() {
            long[,,] intArray = new long[_X_DIMENSION,_Y_DIMENSION,_Z_DIMENSION];
            Random rnd = new Random();
            for(int k = 0; k < _X_DIMENSION; k ++){
                for (int i = 0; i <= _Y_DIMENSION-1; i++)  
                {  
                    for (int j = i+1; j < _Z_DIMENSION; j++)  
                    {  
                        intArray[k,i,j] = rnd.NextInt64(1, 100);
                    }  
                } 
            }
            return intArray;
        }

        public static void Print3dMatrix(long[,,] mtx) {
            Console.WriteLine("Current 3d array: ");
            for(int k = 0; k < _X_DIMENSION; k ++){
                for (int i = 0; i <= _Y_DIMENSION-1; i++)  
                {  
                    for (int j = 0; j < _Z_DIMENSION; j++)  
                    {  
                        Console.Write("{0} ({1}, {2}, {3})\t", mtx[k,i,j], k, i, j);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        public static long[,] SpiralMatrix() {
            Direction direction = new Direction();
            int n = 4;
            long[,] mtx = new long[n,n];
            int rotationCount = n*n;
            int currentRow = 0;
            int currentColumn = 0;

            string currentDirection = direction.Right;

            for(int i = 1; i<=rotationCount; i++){
                if((currentDirection == direction.Right) && (currentColumn > n - 1 || mtx[currentRow, currentColumn] != 0)){
                    currentDirection = direction.Down;
                    currentColumn--;
                    currentRow++;
                }
                if((currentDirection == direction.Down) && (currentRow > n - 1 || mtx[currentRow, currentColumn] != 0)){
                    currentDirection = direction.Left;
                    currentColumn--;
                    currentRow--;
                }
                if((currentDirection == direction.Left) && (currentColumn < 0 || mtx[currentRow, currentColumn] != 0)){
                    currentDirection = direction.Up;
                    currentColumn++;
                    currentRow--;
                }
                if((currentDirection == direction.Up) && (currentRow < 0 || mtx[currentRow, currentColumn] != 0)){
                    currentDirection = direction.Right;
                    currentColumn++;
                    currentRow++;
                }
                mtx[currentRow,currentColumn] = i;
                if(currentDirection == direction.Right) {
                    currentColumn++;
                }

                if(currentDirection == direction.Down) {
                    currentRow++;
                }
                if(currentDirection == direction.Left) {
                    currentColumn--;
                }

                if(currentDirection == direction.Up) {
                    currentRow--;
                }
            }
            return mtx;
        }
        public static void Main(string[] args) {
            long[,] mtx = RandomIntMatrix(_X_DIMENSION, _Y_DIMENSION);
            // Задача 54
            PrintMatrix(mtx);
            PrintMatrix(SortByRow(mtx));
            
            // Задача 56
            MaxByRow(mtx);

            // Задача 58
            long[,] A = RandomIntMatrix(_X_DIMENSION, _Y_DIMENSION);
            long[,] B = RandomIntMatrix(_Y_DIMENSION, _X_DIMENSION);
            Console.WriteLine("Matrix A:");
            PrintMatrix(A);

            Console.WriteLine("Matrix B:");
            PrintMatrix(B);

            Console.WriteLine("Product of matrices A and B:");
            PrintMatrix(MultiplyMatrix(A, B));

            // Задача 60
            long[,,] dmtx = Random3dIntMatrix();
            Print3dMatrix(dmtx);

            // Задача 62
            PrintMatrix(SpiralMatrix());
        }
    }
}