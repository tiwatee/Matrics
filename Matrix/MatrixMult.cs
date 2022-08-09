using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class MatrixMult
    {
        public void MatrixCalc()
        {
            int[,,] arrayCreation = new int[3, 3, 3]{
            {{2,3,3},{4,10,3},{1,0,3} },
            {{2,3,4},{4,10,3},{1,0,6} },
                {{2,3,2},{4,10,5}, {1,0,5} }
        };
            int[,,] arrayCreationTwo = new int[3, 3, 3]{
            {{2,3,4},{4,5,10},{1,5,0} },
            {{2,4,3},{4,3,10},{1,4,0} },
                {{2,3,3},{4,3,10}, {1,5,0} }
        };
            int[,,] arrayOutput = new int[3, 3, 3];
            for (int i = 0; i < arrayCreation.GetLength(0); i++)
            {
                for (int j = 0; j < arrayCreation.GetLength(1); j++)
                {
                    for (int k = 0; k < arrayCreation.GetLength(2); k++)
                    {
                        arrayOutput[i, j, k] += arrayCreation[i, j, k] * arrayCreationTwo[i,k,j];
                    }
                }
            };
            foreach (int i in arrayOutput)
            {
                Console.WriteLine(i);
            }
        }
    }
}
