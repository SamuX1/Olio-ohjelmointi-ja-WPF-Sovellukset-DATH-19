using System;
using System.Collections.Generic;
using System.Text;

namespace StaticTest
{
    // Staattinen luokka "static" avainsanalla
    static class StaattinenLuokka
    {
        public static float KmToMiles(float i)
        {
            float conversion = 0.62137f;

            return i * conversion;
        }
    }
}
