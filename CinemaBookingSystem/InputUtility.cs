//Julian Blair 131011
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bioprogram
{
    /// <summary>
    /// handles truth conditions for userInput
    /// </summary>
    class InputUtility
    {
        public static bool GetDouble(string stringToConvert, out double dblOutValue)
        {
            if (double.TryParse(stringToConvert, out dblOutValue))
            {
                if (dblOutValue > 0)
                    return true;
            }
                return false;
        }
    }
}
