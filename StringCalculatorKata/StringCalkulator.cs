using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
    public static class StringCalkulator
    {


        public static decimal Add(string a)
        {
            if (String.IsNullOrEmpty(a))
            {
                return 0;
            }
            string delimiter = ",";


            var adelimiter = a.Split("\n");
            if (adelimiter[0] != null && adelimiter[0].Contains("//"))
            {
                var bdelimiter = adelimiter[0].Split("//");
                delimiter = bdelimiter[1];

                a = a.Replace(adelimiter[0], "");
                a = a.Remove(0, 1);
               var regexList = Regex.Match(delimiter, @"\[(.*?)\]");
                delimiter = regexList.Value;
                delimiter = delimiter.Replace("[", "");
                delimiter = delimiter.Replace("]", "");
            }

            a = a.Replace("\n", delimiter);
            var split = a.Split(delimiter);

            if (split.Length == 0)
            {
                var zzz = decimal.Parse(a);
                if (zzz > 999)
                    return 0;
                return zzz;
            }
            decimal sum = 0;
            var minusList = new List<decimal>();
            foreach (var item in split)
            {
                var ditem = decimal.Parse(item);
                if (ditem < 0)
                    minusList.Add(ditem);

                if (ditem < 1000)
                {
                    sum += ditem;
                }
            }
            if (minusList.Any())
            {
                throw new ArgumentException("negatives not allowed :" + String.Join(delimiter, minusList));
            }

            return sum;
        }
    }
}
