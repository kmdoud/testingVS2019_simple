using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TestingVS2019_2
{
    class Array
    {

        public int[] arr = new int[50];

        Random rnd = new Random();



        public int iterate()
        {

            for (var idx = 0; idx < 50; idx++)
            {
                arr[idx] = rnd.Next(0, 10000);
            }

            var total = arr.Sum(i => i);
            return total;
        }

        public Array()
        {
            //arr.SetValue(32, 0);
            //arr.SetValue(55, 1);
            
        }

    }
}
