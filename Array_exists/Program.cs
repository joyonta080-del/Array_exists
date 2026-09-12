namespace Array_exists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            bool result = Array.Exists(numbers, x => x > 50);
            Console.WriteLine(result);
            
        }
    }
}
