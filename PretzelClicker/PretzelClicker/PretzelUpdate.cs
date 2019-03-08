using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PretzelClicker
{
    class PretzelUpdate
    {
        public double UpgradeKosten;
        public double NeueKosten;
        
        public double Update(Pretzel Pretzel, double upgrade_wert,double costs)
        {
            if (Pretzel.pretzel > costs)
            {
                Pretzel.pretzel -= costs;
                Pretzel.pretzel_pro_click += upgrade_wert;
                return Pretzel.pretzel_pro_click;
            }
            else
            {
                return Pretzel.pretzel_pro_click;
            }
        }
        public double CalculateCosts()
        {
            return  NeueKosten * 1.5 ;
        }

        public string UpdatePretzelScore(double pretzel )
        {
            return "Pretzel: " + pretzel;
        }

        public string UpdatePretzelProClick(double pretzel_pro_click)
        {
            return "Pretzel_Pro_Click: " + pretzel_pro_click;
        }

    }
}
