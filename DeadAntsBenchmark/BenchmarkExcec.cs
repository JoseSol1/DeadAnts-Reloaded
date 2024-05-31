using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace DeadAntsBenchmark
{
    public class BenchmarkExcec
    {
        [Benchmark]
        public void test()
        {
            int deadAnt = DeadAnts.DeadAntCount("...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t");
            //Console.WriteLine(deadAnt);
            //var deadAnt = new DeadAnts();
            //deadAnt = DeadAnts.DeadAntCount("...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t");
        }
    }
}
