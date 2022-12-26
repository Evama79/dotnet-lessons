namespace Sem6 {
    class Task {
        const int _ARRSIZE = 5;
        public static void Task34(int n){
            List<int> array = new List<int>();
            var rand = new Random();
            while(n > 0) {
                int buf = rand.Next(100, 999);

                array.Add(buf);
                
                n--;
            }
            
            array.ForEach(t => Console.WriteLine(t));

            int count = 0;

            foreach(int _t in array) {
                if(_t % 2 == 0) {
                    count++;
                }
            }

            Console.WriteLine("{0} even numbers", count);

        }
        
        public static void Task36(int n) {
            List<int> array = new List<int>();
            var rand = new Random();
            int sum = 0;

            while(n > 0) {
                int buf = rand.Next(100, 999);
                
                array.Add(buf); 
                n--;
            }

            for(int i=1; i < array.Count; i+=2)
            {
  
                sum = sum + array[i];
            }

            Console.WriteLine("Sum of numbers with odd indexes: {0}", sum);

        }
        public static void Task38(int n) {
            List<int> array = new List<int>();
            var rand = new Random();
            int diff = 0;
            int min = 0, max = 0;
            while(n > 0) {
                int buf = rand.Next(100, 999);
                
                 array.Add(buf); 
                n--;
            }
           
            min = array[0];
            max = array[0];
            for(int i = 0; i < array.Count; i++){
                if(min > array[i]){
                    min = array[i];
                }
                if(max < array[i]) {
                    max = array[i];
                }
            }

            diff = max - min;
            Console.WriteLine("Difference between min and max value: {0}", diff);
        }
        public static void Main(string[] args) {
            
            Task34(_ARRSIZE);
            Task36(_ARRSIZE);
            Task38(_ARRSIZE);
        }
    }
}