using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventOfCode.Day2
{
    public class CubeConundrumPart2
    {
        //Game 1: 30 blue, 4 red; 1 red, 2 green, 6 blue; 2 green
        public string GameCounter(string fileName)
        {
            var inputData = File.ReadLines(fileName);
            var index = 1;
            int sum = 0;

            foreach (var line in inputData)
            {
                var greenCubes = 0;
                var redCubes = 0;
                var blueCubes = 0;
                int gameId = index;
                MatchCollection colorMatches = Regex.Matches(line, @"(\d+)\s+([a-zA-Z]+)");

                foreach (Match colorMatch in colorMatches)
                {
                    int count = int.Parse(colorMatch.Groups[1].Value);
                    string color = colorMatch.Groups[2].Value.ToLower();

                    switch (color)
                    {
                        case "red":
                            redCubes = count > redCubes ? count : redCubes;
                            break;
                        case "green":
                            greenCubes = count > greenCubes ? count : greenCubes;
                            break;
                        case "blue":
                            blueCubes = count > blueCubes ? count : blueCubes;
                            break;
                    }
                }
                sum += greenCubes * redCubes * blueCubes;
            }

            return sum.ToString();
        }
    }
}
