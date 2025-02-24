namespace Searching
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter a value between 0 and 10");
            Random r = new Random();
            int s = int.Parse(Console.ReadLine());
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(0, 10);
            }
            LinearS(array, r,s);
            BinaryS(array, r,s);

        }

        static void LinearS(int[] array, Random r,int s)
        {
            List<int> iList = new List<int>();
            
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == s)
                {
                    iList.Add(i);
                }
            }

            Console.WriteLine($"There are numbers with value - {s} - at {String.Join(",", iList)}");
            Console.WriteLine($"The array is [{String.Join(",", array)}]");
        }
        static void BinaryS(int[] array, Random r,int s)
        {
            List<int> iList = new List<int>();
            
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == s)
                {
                    iList.Add(i);
                }
            }

            Console.WriteLine($"There are numbers with value - {s} - at {String.Join(",", iList)}");
            Console.WriteLine($"The array is [{String.Join(",", array)}]");
        }
    }
}
