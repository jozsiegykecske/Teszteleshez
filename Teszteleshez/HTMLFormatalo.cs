using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teszteleshez
{
    public class HTMLFormatalo
    {
        public string FelkoverSzoveg(string szoveg)
        {
            StringBuilder vissza = new StringBuilder();
            vissza.Append("<b>");
            vissza.Append(szoveg);
            vissza.Append("</b>");
            return vissza.ToString();
        }
    }
}
