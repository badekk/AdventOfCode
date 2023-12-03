using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventOfCode.Day2
{
    public class CubeConundrum
    {
        //Game 1: 30 blue, 4 red; 1 red, 2 green, 6 blue; 2 green
        public string GameCounter(string fileName)
        {
            var inputData = File.ReadLines(fileName);
            var index = 1;
            int sum = 0;

            foreach (var line in inputData)
            {
                int gameId = index;
                bool sumGameIndex = false;
                MatchCollection colorMatches = Regex.Matches(line, @"(\d+)\s+([a-zA-Z]+)");

                foreach (Match colorMatch in colorMatches)
                {
                    int count = int.Parse(colorMatch.Groups[1].Value);
                    string color = colorMatch.Groups[2].Value.ToLower();

                    if (IsGamePossible(color, count))
                    {
                        sumGameIndex= true;
                        continue;
                    }                  
                    else
                    {
                        sumGameIndex = false;
                        break;
                    }
                }

                if(sumGameIndex)
                {
                    sum += gameId;
                }
                index++;
            }

            return sum.ToString();
        }

        public bool IsGamePossible(string color, int count)
        {
            //only 12 red cubes, 13 green cubes, and 14 blue cubes
            int maxRedCubes = 12;
            int maxGreenCubes = 13;
            int maxBlueCubes = 14;
            bool result = false;

            switch (color)
            {
                case "red":
                    result = count <= maxRedCubes;
                    break;
                case "green":
                    result = count <= maxGreenCubes; 
                    break;
                case "blue":
                    result = count <= maxBlueCubes;
                    break;
            }

            return result;
        }
    }
}
