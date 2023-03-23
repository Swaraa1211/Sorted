namespace Sorted
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var exampleIntegerSet = new SortedSet<int>() { 5, 9, 1, 2, 3, 4 };
            //var exampleIntegerSet = new SortedSet<int>() { 1, 2, 3, 4 };
            var exampleCharSet = new SortedSet<int>() { 'A','B','C'};
            foreach (var example in exampleIntegerSet)
            {
                Console.WriteLine($"IntegerSet - {example}");
            }
            foreach (var example in exampleCharSet)
            {
                Console.WriteLine(example);
            }
        }
    }
}