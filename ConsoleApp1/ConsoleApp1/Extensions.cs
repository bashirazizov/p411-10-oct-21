using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace ConsoleApp1
{
    static class Extensions
    {

        public static int Sum(this int a, int b)
        {
            return a + b;
        }

        public static bool isValidEmail(this string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch (Exception)
            {
                return false;
            }


            //if (!email.Contains('@'))
            //{
            //    return false;
            //}

            //string[] parts = email.Split('@');

            //if (parts.Length != 2)
            //{
            //    return false;
            //}

            //if (string.IsNullOrEmpty(parts[0]) || string.IsNullOrEmpty(parts[1]))
            //{
            //    return false;
            //}

            //if (!parts[1].Contains("."))
            //{
            //    return false;
            //}

            //return true;
        }
    }
}
