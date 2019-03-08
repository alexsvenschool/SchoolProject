using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PretzelClicker
{
    class Pretzel
    {
        public double pretzel = 0;
        public double pretzel_pro_click = 1;

        public double Clicked()
        {
            pretzel += pretzel_pro_click;
            return pretzel;
        }
    }

   
}
