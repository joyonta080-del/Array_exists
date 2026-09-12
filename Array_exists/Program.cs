namespace Array_exists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            bool result = Array.Exists(numbers, x => x > 30); //Lambda Expression: x => x > 30
            Console.WriteLine(result);



              /* x = 10 → 10 > 30 → False ❌

               x = 20 → 20 > 30 → False ❌

              x = 30 → 30 > 30 → False ❌

              x = 40 → 40 > 30 → True ✅ */
            
        }
    }
}
