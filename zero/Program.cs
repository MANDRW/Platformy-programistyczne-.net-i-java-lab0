namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz=new FizzBuzz(20);
            fizzBuzz.ConsoleOut();
        }
    }


    public class FizzBuzz
    {
        private int size;

        public FizzBuzz(int n) { size = n; }

        public void ConsoleOut()
        {
            for (int i = 0; i < size; i++)
            {
                if (i % 5 == 0 && i % 3 == 0) Console.WriteLine("FizzBuzz\n");
                else if (i % 3 == 0) Console.WriteLine("Fizz\n");
                else if (i % 5 == 0) Console.WriteLine("Buzz\n");
                else Console.WriteLine(i+"\n");
            }
        }
    }
}