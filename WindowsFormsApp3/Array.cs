using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Array
    {
        List<double> res;

        

        public Array()
        {
            res = new List<double>();
        }

        public void Add(double add)
        {
            res.Add(add);
        }

        public string MidRange()
        {
            double result = 0;
            foreach (double i in res)
            {
                result += i;
            }

            

            return Convert.ToString(result / res.Count);
        }

    }
}
