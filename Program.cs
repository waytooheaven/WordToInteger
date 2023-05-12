using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordToInteger
{
    public class Program
    {
        private static Dictionary<string, long> numberTable =
        new Dictionary<string, long>
        {{"zero",0},{"one",1},{"two",2},{"three",3},{"four",4},
        {"five",5},{"six",6},{"seven",7},{"eight",8},{"nine",9},
        {"ten",10},{"eleven",11},{"twelve",12},{"thirteen",13},
        {"fourteen",14},{"fifteen",15},{"sixteen",16},
        {"seventeen",17},{"eighteen",18},{"nineteen",19},{"twenty",20},
        {"thirty",30},{"forty",40},{"fifty",50},{"sixty",60},
        {"seventy",70},{"eighty",80},{"ninety",90},{"hundred",100}, {"hundreds",100},
        {"thousand",1000}, {"thousands",1000},{"million",1000000},{"millions",1000000},{"billion",1000000000},{"billions",1000000000},
        {"trillion",1000000000000},{"trillions",1000000000000},{"quadrillion",1000000000000000},{"quadrillions",1000000000000000},
        {"quintillion",1000000000000000000},{"quintillions",1000000000000000000}};

        private static List<string> Suffixes = new List<string> {"hundreds", "millions", "billions", "trillions", "quadrillions", "quintillions" };
        static void Main(string[] args)
        {
            Console.Write("Enter the input string:");
            var inputString = Console.ReadLine();
            Console.WriteLine(ParseEnglish(inputString));
            Console.ReadLine();
        }
        public static string ParseEnglish(string words)
        {
            string result = "";
            var wordArray = words.Split(' ');
            for(int i = 0; i < wordArray.Length; ++i)
            {
                var word = wordArray[i];
                if (numberTable.Keys.Contains(word))
                {
                    if (Suffixes.Contains(wordArray[i + 1])){
                        result += numberTable[word] * numberTable[wordArray[i + 1]] + " ";
                        ++i;
                    }
                    else
                    {
                        result += numberTable[word] + " ";
                    }
                }
                else
                {
                    result += word + " ";
                }
            }
            result = result.Remove(result.LastIndexOf(" "));
            return result;
        }
    }
}
