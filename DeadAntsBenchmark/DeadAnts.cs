using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadAntsBenchmark
{
    public class DeadAnts
    {
        public static int DeadAntCount(string ants)
        {
            if (ants == null)
            {
                return 0;
            }
            string notComplete = ants.Replace("ant", "");
            int a = 0, n = 0, t = 0;
            foreach (char car in notComplete)
            {
                if (car == 'a')
                {
                    a++;
                }
                else if (car == 'n')
                {
                    n++;
                }
                else if (car == 't')
                {
                    t++;
                }

            }

            return Math.Max(Math.Max(a, n), t);
        }
    }
}
