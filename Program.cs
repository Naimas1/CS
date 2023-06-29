namespace CS
{
    public class Program
    {
        static void TestTaskOneLab()
        {
            string info = "TestArray";
            MyArray array = new MyArray();
            array.Show(info);
        }
        static void TestTaskTwoLab()
        {
            MyArray array = new MyArray(new int[]{ 1, 2, 3, 4, 5 });
            Console.WriteLine($"Max: {array.Max()}");
            Console.WriteLine($"Min: {array.Min()}");
            Console.WriteLine($"Avg: {array.Avg()}");
            Console.WriteLine($"Search: {array.Search(8)}");
        }
        static void TestTaskThreeLab()
        {
            MyArray array = new MyArray(new int[] { 1, 2, 3, 4, 5 });
            array.SortAsc();
            Console.WriteLine(array.ToString());
            array.SortDesc();
            Console.WriteLine(array.ToString());
            array.SortByParam(true);
            Console.WriteLine(array.ToString());
        }
        static void TestTaskOneHW()
        {
            MyArray myArray = new MyArray(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine(myArray.Less(4));
            Console.WriteLine(myArray.Greater(2));

        }
        static void TestTaskTwoHW()
        {
            MyArray myArray = new MyArray(new int[] { 1, 2, 3, 4, 5 });
            myArray.ShowEven();
            myArray.ShowOdd();
        }
        static void TestTaskThreeHW()
        {
            MyArray myArray = new MyArray(new int[] { 1, 2, 4, 3, 3 });
            Console.WriteLine(myArray.CountDistinct());
            Console.WriteLine(myArray.EqualToValue(3));
        }

        static void Main()
        {
            //TestTaskOneLab();
            //TestTaskTwoLab();
            //TestTaskThreeLab();

            //TestTaskOneHW();
            //TestTaskTwoHW();
            TestTaskThreeHW();
        }
    }
}