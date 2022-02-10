using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teszteleshez
{
    public class Tombos
    {
        //return list generál
        public List<int> General(int x)
        {
            List<int> visszaad = new List<int> {1};
            int szamlalo = 3;
            while (szamlalo < x)
            {
                visszaad.Add(szamlalo);
                szamlalo += 2;
            }
            return visszaad;
        }
    }
}
