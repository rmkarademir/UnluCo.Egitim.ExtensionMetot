using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnluCo.Egitim.ExtensionMethod
{
    public static class PasswordValid2
    {
        public static IValidationRule[] GetRules()
        {
            IValidationRule[] rules = { 
                new IsUppercaseValidationRule(), 
                new IsLowercaseValidationRule(),
                new IsDigitValidationRule(), 
                new IsLengthValidationRule() };//Yapilacak kontrollerin listesi.
            return rules;
        }
        
        public static bool isValidPassword2(this string password)
        {
            bool result = false;
            foreach(var rule in GetRules())
            {
                result = rule.isValid(password);//Verilen kontrol türleri tek tek denenir.
                if (result is false) return false;//Kontrolden gecemezse false doner.
            }
            return true;//Tum kontrollerden gecerse true doner.
        }
    }
    /*public static class StringExtensions
    {
        public static bool isValidPassword(this string str, bool isUppercase = false, bool isDigit=false)
        {
            bool result = false;
            if (!isUppercase && !isDigit) return true;
            if (isDigit)
                result = str.Any(x => Char.IsDigit(x));
            if (isUppercase)
                result = str.Any(x => Char.IsUpper(x));
            return result;
        }
    }*/
}
