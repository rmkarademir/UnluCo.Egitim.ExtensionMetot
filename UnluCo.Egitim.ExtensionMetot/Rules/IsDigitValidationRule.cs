using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnluCo.Egitim.ExtensionMethod
{
    class IsDigitValidationRule : IValidationRule
    {
        public bool isValid(string str)
        {
            return str.Any(x => Char.IsDigit(x));//Sifrede rakam var mi?
        }
    }
}
