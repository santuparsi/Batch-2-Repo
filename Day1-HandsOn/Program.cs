namespace Day1_HandsOn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 12, 23, 34, 45, 56, 67, 78 };
            //sum or array nos;
            int sum = n.Sum();
            Console.WriteLine(sum);
            //sum of even values
            sum = n.Where(x => x % 2 == 0).Sum();
            Console.WriteLine("Hello, World!");
        }
    }
}