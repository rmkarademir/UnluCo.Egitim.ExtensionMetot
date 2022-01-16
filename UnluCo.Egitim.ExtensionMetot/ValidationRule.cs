using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnluCo.Egitim.ExtensionMethod
{
    public abstract class ValidationRule
    {
        public abstract bool isValid(string str);
    }
}
