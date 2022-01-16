using System;
using System.Collections.Generic;

namespace UnluCo.Egitim.ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidationRule[] rules = { new IsUppercaseValidationRule(), new IsLowercaseValidationRule(), 
                new IsDigitValidationRule(), new IsLengthValidationRule() };//Yapilacak kontrollerin listesi.
            string password = "abcD1234";
            Console.WriteLine("Şifre kontrolden geçti mi? = " + 
                (password.isValidPassword(rules) ? "Evet" : "Hayır"));
        }
    }
}
