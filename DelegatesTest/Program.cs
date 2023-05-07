
namespace DelegatesTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test test = TheTest;

            test("fdsf");
            TheTest("fsadf");
        }

        public delegate void Test(string text);

        public static void TheTest(string text)
        {
            Console.WriteLine(text);
        }
    }
}