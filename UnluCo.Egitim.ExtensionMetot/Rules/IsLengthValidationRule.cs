using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnluCo.Egitim.ExtensionMethod
{
    class IsLengthValidationRule : ValidationRule
    {
        public override bool isValid(string str)
        {
            return str.Length >= 8;//Sifre uzunlugu 8 den fazla mi?
        }
    }
}
