namespace PillarsOop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;

            FurtherMaths cObject = new FurtherMaths();
            // Calculator cRefObject = new ScientificCalc();
            Mathematics cRefObject = cObject;

            Console.WriteLine("                           OOP PILLARS");
            Console.WriteLine("=================================================================== ");
            Console.WriteLine("Enter 1st Number: ");
            x = Convert.ToInt32(Console.ReadLine());

            // x = int.TryParse(Console.ReadLine());

            Console.WriteLine("Enter 2nd Number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            cRefObject.Addition(x, y);
            cRefObject.Multiplication(x, y);
            cRefObject.Subtraction(x, y);
            cRefObject.Division(x, y);

            cRefObject.Modulus(x, y);
            cRefObject.Modulus(x, y, 40);
            cObject.Exponent(x, y);

            Console.WriteLine("");
            cRefObject.Exponent();

            Console.WriteLine("");
            cObject.Display();   //independent methods in child class can be accessed by instance of child but not parent class




        }
    }
}