using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PillarsOop
{
    //Abstraction & Encapsulation
    abstract class Mathematics
    {
        public int Addition(double x, double y)
        {
            double z;
            z = x + y;
            Console.WriteLine("Addition Result: " + z);
            return (int)z;

        }
        public void Subtraction(double input1, double input2)
        {
            Console.WriteLine("Subtraction Result: " + (input1 - input2));
        }

        public double Modulus(double input1, double input2)
        {
            Console.WriteLine("Modulus result: " + (input1 % input2));
            return input1 % input2;
        }
        //Method Overload
        public void Modulus(double input1, double input2, int input3)
        {
            Console.WriteLine("Modulus result 2: " + (input1 % input2 + input3));
        }
        public void Exponent()
        {
            Console.WriteLine("This is an independent method");
        }

        private int specialnum1 = 6;
        private double specialnum2 = 0.2;
        public int Calculator { get { return specialnum1; } set { specialnum1 = value; } }
        public double ScientificCalc { get { return specialnum2; } }
        abstract public void Division(double input1, double input2);
        abstract public void Multiplication(double input1, double input2);


    }

    class FurtherMaths : Mathematics
    {
        //Method Override
        override public void Division(double input1, double input2)
        {
            Console.WriteLine("Division Result: " + input1 / input2);


        }
        override public void Multiplication(double input1, double input2)
        {
            Console.WriteLine("Multiplication Result: " + input1 * input2);

        }

        //Individual methods of Childclass
        public void Display()
        {
            Console.WriteLine("I am an independent method in child class");
        }

        public void Exponent(double input1, double input2)
        {
            Console.WriteLine("Exponent Result: " + Math.Pow(input1, input2));
        }


        //private void Fraction(double specialnum1, double specialnum2)
        //{
        //    double num3 = specialnum1 / specialnum2;
        //    Console.WriteLine("Fraction Result: " + num3);
        //   // Multiplication(specialnum1,specialnum2);

        //}


        //public void Division1(double num1, double num2)
        //{
        //    Fraction(num1, num2);
        //    Console.WriteLine("Second Division Result: " + specialnum1/specialnum2);



    }

}

