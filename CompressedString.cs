using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Consoledemo
{
    Class Program{
    
    static void Main(string[] args
    {
          var dict = objP1.printCompressedString("aaa31b9c12b12c22d3c0e0");

            var compressedString = new StringBuilder();
            foreach (var item in dict)
            {
                compressedString.Append($"{item.Key}{item.Value}");
            }
            Console.WriteLine(compressedString.ToString());
        }
      }
     private Dictionary<char, int> printCompressedString(string original)
     {
            var charCount = new Dictionary<char, int>();
            for (int i = 0; i < original.Length; i++)
            {

                if (!char.IsDigit(original[i]))
                {
                    if (!charCount.ContainsKey(original[i]))
                    {
                        charCount.Add(original[i], 1);
                    }
                    else
                    {
                        var existingValue = charCount[original[i]];
                        charCount[original[i]] = ++existingValue;
                    }
                }
                else
                {
                    var prev = original[i - 1];
                    var stringBuilder = new StringBuilder();
                    int j = i;
                    while (j < original.Length - 1 && char.IsDigit(original[j]))
                    {

                        stringBuilder.Append(original[j]);
                        j++;
                    }
                    i = i != j ? j - 1 : i;
                    int digit = convertStringToDigits(stringBuilder.ToString());

                    var prevValue = charCount[prev];
                    charCount[prev] = prevValue + digit;
                }
            }
            return charCount;
        }
        private int convertStringToDigits(string digits)
        {
            int newNum = 0;
            int i = digits.Length - 1;
            int index = 0;
            while (i >= 0)
            {
                int d = digits[i] - 48;
                newNum = (Convert.ToInt32(Math.Pow(10, index)) * d) + newNum;
                index++;
                i--;
            }



            return newNum;
        }
  }
}
