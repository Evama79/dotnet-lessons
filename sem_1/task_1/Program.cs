namespace task_1 {
    class Max{
        public static void Main(string[] args){
            Console.WriteLine("Введите первое число"); //нахождение максимального из двух чисел
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a > b ? a : b);       }
    }
}