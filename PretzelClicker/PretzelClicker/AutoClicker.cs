using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PretzelClicker
{
    public class AutoClicker : IPretzelUpgrade
    {  
        private static int count;
        private static int multiplikator = 1;
        private static readonly double effecient = 1.08;

        public AutoClicker()
        {
            count++;
        }        
        public static int Count(){
            return count;
        }
        public BigInteger Costs()
        {
            return (BigInteger)(10 * Math.Pow(effecient, count)) ;
        }

        public static BigInteger Value()
        {
            return multiplikator * count * 1;
        }

        public static void AddUpgrade(int mult = 1)
        {
            multiplikator += mult;
        }
    }
}
