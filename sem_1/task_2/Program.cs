namespace task_2
{
    class Max{
    // максимальное из трех чисел
    static int FindMax(int a, int b, int c) 
    {
        //2 1 3
        if (a > b){
            if (a > c){
                return a;
            }
            else {
                return c;
            }
        }
        else {
            if (b > c){
                return b;
            }
           else {
            return c;
           } 
        }
    }
        public static void Main(string[] args){
            Console.WriteLine("Введите первое число"); //нахождение максимального из двух чисел
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            int c = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine(FindMax(a, b, c));     
        }
    }

}