using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFCResourceManagement
{
    class clsValidatingFunctions
    {
        public static bool NotEmpty(string target)
        {
            return (target.Length > 0);
        }

        public static bool IsDigit(string target)
        {
            Regex isNumericRegex = new Regex(@"^\d*$");
            return isNumericRegex.IsMatch(target);
            
        }
    }
}
