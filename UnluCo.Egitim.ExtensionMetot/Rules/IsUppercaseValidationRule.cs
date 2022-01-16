using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnluCo.Egitim.ExtensionMethod
{
    class IsUppercaseValidationRule : ValidationRule
    {
        public override bool isValid(string str)
        {
            return str.Any(x => Char.IsUpper(x));//Sifrede buyuk harf var mi?
        }
    }
}
