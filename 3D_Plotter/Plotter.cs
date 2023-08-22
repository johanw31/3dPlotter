using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Plotter
{
    internal static class Plotter
    {
        public static int Fakul(int n)
        {
            if (n == 1)
            {
                
                return 1;
            }
            return Fakul(n-1)*n;
        }
    }
}
