using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StringUtils
    {
        public string Reverse(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("Invalid input");
            }

            StringBuilder sb = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                sb.Append(input[i]);
            }

            return sb.ToString();
        }
    }
}
