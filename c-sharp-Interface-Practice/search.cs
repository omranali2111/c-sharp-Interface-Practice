using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_Interface_Practice
{
    internal class search
    {

        public  (int, int) searchForElement(int[,] arr, int target)
        {

            for (int row = 0; row < arr.GetLength(0); row++)
            {

                for (int column = 0; column < arr.GetLength(1); column++)
                {

                    if (arr[row, column] == target)
                    {
                        return (row, column);
                    }



                }

            }

            return (-1, -1);


        }
    }
}
