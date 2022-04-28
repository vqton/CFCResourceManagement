using System;
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
    }
}
