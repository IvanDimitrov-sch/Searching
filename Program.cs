namespace Searching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> iList = new List<int>();
            Random r = new Random();
            int[] array = new int[10];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(0, 10);
            }
            Console.WriteLine("enter a value between 0 and 10");
            int s = int.Parse(Console.ReadLine());  
            for(int i =0; i < array.Length; i++)
            {
                if(array[i] == s)
                {
                    iList.Add(i);
                }
            }

            Console.WriteLine($"There are numbers with value - {s} - at {String.Join(",", iList)}");
            Console.WriteLine($"The array is [{String.Join(",", array)}]");


        }
    }
}
