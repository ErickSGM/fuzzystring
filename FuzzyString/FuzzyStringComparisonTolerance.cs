using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyString
{
    public class Helper
    {
        public static Dictionary<FuzzyStringComparisonTolerance, double> MinimumTolerance { get; set; } = new Dictionary<FuzzyStringComparisonTolerance, double>
        {
            { FuzzyStringComparisonTolerance.Strong, 0.25 },
            { FuzzyStringComparisonTolerance.Normal, 0.50 },
            { FuzzyStringComparisonTolerance.Weak, 0.75 },
            { FuzzyStringComparisonTolerance.Manual, 0.6 },
        };
    }
    
    public enum FuzzyStringComparisonTolerance
    {
        Strong,

        Normal,

        Weak,

        Manual
    }
}
