using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DotNetSandBox.Helpers.Extensions
{
    public static class Extensions
    {
        public static bool IsValidNumber(this string str)
        {
            Regex regexPattern = new Regex(@"[0-9]+$");

            if (regexPattern.IsMatch(str)) return true;
            else return false;
        }
    }
}
