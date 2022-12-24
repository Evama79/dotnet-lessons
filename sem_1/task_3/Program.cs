/*
Задача 6: Напишите программу, которая на вход принимает 
число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
*/
namespace task_3 {
    class Max{
        static string IsEven(int a){
            if (a % 2 == 1){
                return "Нечетное";    
            }
            else 
            {
                return "Четное";
            }
        }
        public static void Main(string[] args){
            Console.WriteLine("Введите число"); 
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsEven(a));
    }
}
}