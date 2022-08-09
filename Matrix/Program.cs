namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            MatrixMult mult = new MatrixMult();
            mult.MatrixCalc();

            Determinant determinantFourD = new Determinant();
            Console.WriteLine("What is the size of the array for determinant?");
            determinantFourD.ArrayLength = Convert.ToInt32(Console.ReadLine());
            int arrayLen = determinantFourD.ArrayLength;

            int[,] fourDimArray = determinantFourD.ArrayValues(arrayLen);
            Console.WriteLine( "The determinant is {0}",determinantFourD.Calculation(fourDimArray));

        }
    }
}