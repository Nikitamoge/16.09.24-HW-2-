
namespace Interface
{
    //Task 1
    public interface IShow
    {
        void Show();
        void Info();
    }

    //Task 2
    public interface IMath
    {
        void Max();
        void Min();
        void Average();
        bool Search(int valueToSearch);
    }

    //Task 3
    public interface ISort
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);
    }

    class Aray : IShow, IMath, ISort
    {
        public int[] arr { get; set; }

        public Aray(int[] ar)
        {
            arr = ar;
        }

        public void Info()
        {
            Console.WriteLine("Array elements: " + string.Join(", ", arr));
        }

        public void Show()
        {
            Console.WriteLine("Array of length: " + arr.Length);
        }

        public void Max()
        {
            int max = arr.Max();
            Console.WriteLine("Max: " + max);
        }

        public void Min()
        {
            int min = arr.Min();
            Console.WriteLine("Min: " + min);
        }

        public void Average()
        {
            double average = arr.Average();
            Console.WriteLine("Average: " + average);
        }

        public bool Search(int valueToSearch)
        {
            bool found = arr.Contains(valueToSearch);
            Console.WriteLine(found ? "Match found" : "Match not found");
            return found;
        }

        public void SortAsc()
        {
            Array.Sort(arr);
            Console.WriteLine("Sorted Ascending:");
        }

        public void SortDesc()
        {
            Array.Sort(arr);
            Array.Reverse(arr);
            Console.WriteLine("Sorted Descending:");
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Aray obj = new Aray(new int[] { 1, 4, 2, 5, 3 });

            //Task 1
            obj.Info();
            obj.Show();

            //Task 2
            obj.Max();
            obj.Min();
            obj.Average();
            obj.Search(5);

            //Task 3
            obj.SortAsc();
            obj.Info();
            obj.SortDesc();
            obj.Info();
            obj.SortByParam(true);
            obj.Info();
        }
    }
}
