using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project1
{
    internal class LDTUtils
    {
        public static Boolean isNumberValid(String num)
        {
            Regex regex = new Regex(@"^[0-9]*$");
            //if (regex.IsMatch(num))
            //{
            //   return true;
            //}
            return regex.IsMatch(num);
        }
    }
}
