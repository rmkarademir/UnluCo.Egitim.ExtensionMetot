using System;
using System.Collections.Generic;

namespace UnluCo.Egitim.ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IValidationRule[] rules = { 
                new IsLowercaseValidationRule(), 
                new IsDigitValidationRule(), 
                new IsLengthValidationRule() };//Yapilacak kontrollerin listesi.
            string password = "abc01234";
            Console.WriteLine("Şifre kontrolden geçti mi? = " +
                (password.isValidPassword(rules) ? "Evet" : "Hayır"));//mainde verilen kurallar ile kontol yapılıyor.
            Console.WriteLine(" ");
            Console.WriteLine("Şifre kontrolden geçti mi? = " + 
                (password.isValidPassword2() ? "Evet" : "Hayır"));//StringExtensions2 dosyası içerisinde verilen kurallar ile kontol yapılıyor.
        }
    }
}
