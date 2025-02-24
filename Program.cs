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
            Console.WriteLine("-------This is linear search-------\n\n");
            List<int> iList = new List<int>();
            
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == s)
                {
                    iList.Add(i);
                }
            }

            Console.WriteLine($"There are numbers with value - {s} - {(iList.Count == 0 ? "No such number in the list" : "at" + String.Join(",", iList))} ");
            Console.WriteLine($"The array is [{String.Join(",", array)}]'\n\n");
        }
        static void BinaryS(int[] array, Random r,int s)
        {
            Console.WriteLine("-------This is binary search-------\n\n");
            List<int> iList = new List<int>();

            
            int left = 0;
            int right = array.Length - 1;

            while(left <= right)
            {
                int mid = left + (right - left) / 2;
                if(array[left] == s)
                {
                    iList.Add(left);
                }else if (array[mid] < s)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            Console.WriteLine($"There are numbers with value - {s} - {(iList.Count == 0 ? "No such number in the list" : "at" + String.Join(",", iList))}");
            Console.WriteLine($"The array is [{String.Join(",", array)}]");
        }
    }
}
