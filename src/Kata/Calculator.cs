using System;
using System.Globalization;
using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add( string number="")
        {
            if(string.IsNullOrEmpty(number))
                return 0;
            
            var numbers = number.Split(",");

            if (numbers.Length>1) 
                return Convert.ToInt32(numbers[0])+Convert.ToInt32(numbers[1]);
            return Convert.ToInt32(numbers[0]);
        }
    }
}