namespace HelloWorld
{
    public class Program
    {
#pragma warning disable CA1801 // Parameter args of method Main is never used
        public static void Main(string[] args)
#pragma warning restore CA1801 // Parameter args of method Main is never used
        {
            Console.WriteLine(GetHelloWorldMessage());
        }

        /// <summary>
        /// Generates the "Hello World!" message.
        /// </summary>
        /// <returns>A string containing "Hello World!".</returns>
        public static string GetHelloWorldMessage()
        {
            return "Hello World!";
        }
    }
}
