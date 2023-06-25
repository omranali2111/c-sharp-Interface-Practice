using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_Interface_Practice
{
    internal class search
    {

        public  int searchForElement(int[] arr, int target)
        {

            for (int row = 0; row < arr.GetLength(0); row++)
            {

               

                    if (arr[row] == target)
                    {
                        return (row);
                    }


            }

            return (-1);


        }
    }
}
