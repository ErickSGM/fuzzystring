using System;
using System.Collections.Generic;
using FuzzyString;

namespace FuzzyStringConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var parameters =  Console.ReadLine().Split(' ');
                string data = parameters[0].Replace("_", " ");
                string input = parameters[1].Replace("_", " ");

                List<FuzzyStringComparisonOptions> options = new List<FuzzyStringComparisonOptions>();
                options.Add(FuzzyStringComparisonOptions.UseJaccardDistance);
                //options.Add(FuzzyStringComparisonOptions.UseNormalizedLevenshteinDistance);
                options.Add(FuzzyStringComparisonOptions.UseOverlapCoefficient);
                options.Add(FuzzyStringComparisonOptions.UseLongestCommonSubsequence);
                
                var list = new[] {FuzzyStringComparisonTolerance.Weak, FuzzyStringComparisonTolerance.Normal, FuzzyStringComparisonTolerance.Strong};
                foreach (var fuzzyStringComparisonTolerance in list)
                {
                    Console.ReadLine();
                    var result = data.ApproximatelyEquals(input, fuzzyStringComparisonTolerance, options.ToArray());
                    result
                        .Some(x => Console.WriteLine($"Tolerance: {fuzzyStringComparisonTolerance} | Match: {true} | Average: {x.Average}"))
                        .None(() => Console.WriteLine($"Tolerance: {fuzzyStringComparisonTolerance} | Match: {false}"));
                }
            }
            
        }
    }
}
