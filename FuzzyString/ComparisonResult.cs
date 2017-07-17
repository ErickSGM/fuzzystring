namespace FuzzyString
{
    public class ComparisonResult
    {
        public double Average { get; }
        public bool Match { get; }
        public ComparisonResult(double average, bool match)
        {
            Average = average;
            Match = match;
        }
    }
}