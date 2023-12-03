using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Day_1
{
    public class Trebuchet
    {
        public string ReadAndSumTextFile(string fileName)
        {
            int sum = 0;
            var inputData = File.ReadLines(fileName);

            string firstDigit = "0";
            string lastDigit = "0";

            foreach (var lineOfData in inputData)
            {
                var allDigitsLine = ChangeTextNumbersIntoDigits(lineOfData);
                firstDigit = allDigitsLine.First(x => Char.IsDigit(x)).ToString(); 
                lastDigit = allDigitsLine.Last(x => Char.IsDigit(x)).ToString();
                                             
                int combinedNumber = int.Parse(firstDigit.ToString() + lastDigit.ToString());
                sum += combinedNumber;
            }

            return sum.ToString();
        }

        public string ChangeTextNumbersIntoDigits(string text)
        {
            text = text.Replace("one", "o1e", StringComparison.InvariantCultureIgnoreCase);
            text = text.Replace("two", "t2o", StringComparison.InvariantCultureIgnoreCase);
            text = text.Replace("three", "t3e", StringComparison.InvariantCultureIgnoreCase);
            text = text.Replace("four", "f4r", StringComparison.InvariantCultureIgnoreCase);
            text = text.Replace("five", "f5e", StringComparison.InvariantCultureIgnoreCase);
            text = text.Replace("six", "s6x", StringComparison.InvariantCultureIgnoreCase);
            text = text.Replace("seven", "s7n", StringComparison.InvariantCultureIgnoreCase);
            text = text.Replace("eight", "e8t", StringComparison.InvariantCultureIgnoreCase);
            text = text.Replace("nine", "n9e", StringComparison.InvariantCultureIgnoreCase);

            return text;
        }
    }
}
