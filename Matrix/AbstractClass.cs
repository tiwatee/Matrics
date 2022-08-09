using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal abstract class MatrixAbstractClass
    {
        private int arrayLength;
        public int ArrayLength
        {
            get { return arrayLength; }
            set { arrayLength = value; }
        }

        public int[,] ArrayValues(int arrayLength)
        {
            int[,] arrayCreation = new int[arrayLength, arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                for (int j=0; j < arrayLength; j++)
                {
                    Console.WriteLine("Enter value at row {0}, column {1}",i,j);
                    arrayCreation[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return arrayCreation;
        }
    }
}
