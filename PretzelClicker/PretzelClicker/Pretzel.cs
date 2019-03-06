using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PretzelClicker
{
    class Pretzel
    {
        public int pretzel = 0;
        public int pretzel_pro_click = 1;

        public void Clicked()
        {
            pretzel += pretzel_pro_click;
        }
    }

   
}
