namespace _4matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] mx = new int[,] { { 3, 8, 5, 6 } ,
                                     { 4, 6, 6, 9 },
                                      { 4, 2, 5, 6 },
                                       { 6, 3, 7, 2 } };


            int determinant = ((mx[0, 0] * (mx[1, 1] * ((mx[2, 2] * mx[3, 3]) - (mx[2, 3] * mx[3, 2]))) - (mx[1, 2] * ((mx[2, 1] * mx[3, 3]) - (mx[2, 3] * mx[3, 1])))
                              + (mx[1, 3] * ((mx[2, 1] * mx[3, 2]) - (mx[2, 2] * mx[3, 1]))))
                              - (mx[0, 1] * (mx[1, 0] * ((mx[2, 2] * mx[3, 3]) - (mx[2, 3] * mx[3, 2]))) - (mx[1, 2] * ((mx[2, 0] * mx[3, 3]) - (mx[2, 3] * mx[3, 0])))
                              + (mx[1, 3] * ((mx[2, 1] * mx[3, 2]) - (mx[2, 2] * mx[3, 0]))))
                              + (mx[0, 2] * (mx[1, 0] * ((mx[2, 1] * mx[3, 3]) - (mx[2, 3] * mx[3, 1]))) - (mx[1, 1] * ((mx[2, 0] * mx[3, 3]) - (mx[2, 3] * mx[3, 0])))
                              + (mx[1, 3] * ((mx[2, 0] * mx[3, 3]) - (mx[2, 1] * mx[3, 0]))))
                              - (mx[0, 3] * (mx[1, 0] * ((mx[2, 1] * mx[3, 2]) - (mx[2, 2] * mx[3, 1]))) - (mx[1, 1] * ((mx[2, 0] * mx[3, 2]) - (mx[2, 2] * mx[3, 0])))
                              + (mx[1, 2] * ((mx[2, 0] * mx[3, 1]) - (mx[2, 1] * mx[3, 0])))));

            Console.WriteLine("The Determinant of the matrix is {0}", determinant);
        }
    }
}