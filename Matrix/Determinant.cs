using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class Determinant:MatrixAbstractClass
    {
        public int Calculation(int[,] myArray)
        {
            int caseOne = myArray[0, 0] *
                (
                (myArray[1,1]*((myArray[2, 2] * myArray[3, 3]) - (myArray[3,2]*myArray[2,3])))-
                (myArray[1,2]*((myArray[2, 1] * myArray[3, 3]) - (myArray[3, 1] * myArray[2, 3])))+
                (myArray[1,3]*((myArray[2, 1] * myArray[3, 2]) - (myArray[3, 1] * myArray[2, 2])))    
            );
            int caseTwo = myArray[0, 1] *
                (
                (myArray[1, 0] * ((myArray[2, 2] * myArray[3, 3]) - (myArray[3, 2] * myArray[2, 3]))) -
                (myArray[1, 2] * ((myArray[2, 0] * myArray[3, 3]) - (myArray[3, 0] * myArray[2, 3]))) +
                (myArray[1, 3] * ((myArray[2, 0] * myArray[3, 2]) - (myArray[3, 0] * myArray[2, 2])))
            );
            int caseThree = myArray[0, 2] *
                (
                (myArray[1, 0] * ((myArray[2, 1] * myArray[3, 3]) - (myArray[3, 1] * myArray[2, 3]))) -
                (myArray[1, 1] * ((myArray[2, 0] * myArray[3, 3]) - (myArray[3, 0] * myArray[2, 1]))) +
                (myArray[1, 3] * ((myArray[2, 0] * myArray[3, 1]) - (myArray[3, 0] * myArray[2, 1])))
            );
            int caseFour = myArray[0, 3] *
                (
                (myArray[1, 0] * ((myArray[2, 1] * myArray[3, 2]) - (myArray[3, 1] * myArray[2, 2]))) -
                (myArray[1, 1] * ((myArray[2, 0] * myArray[3, 2]) - (myArray[3, 0] * myArray[2, 2]))) +
                (myArray[1, 2] * ((myArray[2, 0] * myArray[3, 1]) - (myArray[3, 0] * myArray[2, 1])))
            );



            int determinant = caseOne - caseTwo + caseThree - caseFour;
            return determinant;
        }

    }
}
