namespace Matrix3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a, b, r, c;
            //Console.WriteLine("Enter Total rows and Column: ");
            //r = Convert.ToInt32(Console.ReadLine());
            //c = Convert.ToInt32(Console.ReadLine());
            //int[,]d = new int[r, c];
            //Console.WriteLine("Enter the First Matrix");
            //for (a = 0; a < r; a++)
            //{
            //    for (b = 0; b < c; b++)
            //    {
            //        d[a, b] = int.Parse(Console.ReadLine());

            //    }
            //    Console.WriteLine();
            //}
            //int [,]e = new int[r, c];
            //Console.WriteLine("Enter second matrix data");
            //    for (a = 0; a < r; a++)
            //    {
            //        for (b = 0; b < c; b++)
            //        {
            //            Console.Write(d[a, b] + "\t");
            //        }
            //        Console.WriteLine();
            //    }
            //int[,] f = new int[r, c];
            //Console.WriteLine("Enter second matrix data");
            //for (a = 0; a < r; a++)
            //{
            //    for (b = 0; b < c; b++)
            //    {
            //        d[a, b] = int.Parse(Console.ReadLine());

            //    }
            //    Console.WriteLine("Enter 2nd matrix data ");
            //    for (a = 0; a < r; a++)
            //    {
            //        for (b = 0; b < c; b++)
            //        {
            //            d[a, b] = int.Parse(Console.ReadLine());
            //            Console.Write(d[a, b] + "\t");
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine("Multiplication Result: ");
            //    int x, y;
            //    int[,] g = new int[r, c];
            //    for (a = 0; a < r; a++)
            //    {
            //        for (b = 0; b < c; b++)
            //        {
            //            f[a, b] = 0;
            //            for (d = 0; d < 2; d++)
            //            {
            //                f[a, b] += x[a, k] * y[d, b];
            //            }
            //        }

            //        for (a = 0; a < r; a++)
            //        {
            //            for (b = 0; b < c; b++)
            //            {
            //                Console.WriteLine(f[a, b] + "\t");
            //            }
            //            Console.WriteLine();
            //        }
            //        Console.ReadLine();

           //
            int[,,] threeDimArray = new int[2, 3, 2]
            {
                { { 1, 3 }, { 4, 8 }, { 1, 0 }, },
                { { 5, 3 }, { 7, 9 }, { 3, 6 } }
            };
            int[,,] threeDimArray2 = new int[2, 3, 2]
            {
               //{ { 2, 3, 4 }, { 3, 2, 5 }, { 5, 7, 5 } },
               // { { 3, 6, 3 }, { 4, 2, 6 }, { 4, 3, 8 } }
             { { 1, 5 }, { 4, 8 }, { 1, 6 }, },
                { { 7, 3 }, { 4, 9 }, { 0, 6 } }
            };
            
            int[,,] threeDimArray3 = new int[2,3,2];

            for (int i = 0; i < threeDimArray.GetLength(0); i++)
            {
                for (int j = 0; j < threeDimArray2.GetLength(1); j++)
                {
                    for (int k = 0; k < threeDimArray.GetLength(2); k++)
                    {
                        threeDimArray3[i, j, k] += threeDimArray[i, j, k] * threeDimArray2[i, j, k];
                    }
                }

            }
            foreach(int i in threeDimArray3){
                Console.WriteLine(i);
            }


            //float determinant = (threeDimArray[0, 0] * threeDimArray2[1, 1])
            //(threeDimArray[0, 1] * threeDimArray2[1, 0]);

            //Console.WriteLine();


        }
    }
}
