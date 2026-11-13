namespace FeedCalculator
{
    public class FeedCalculatorModel
    {
        public const double CowWeight = 400.0;

        public int? Calves0To8 { get; set; }
        public int? Calves9To15 { get; set; }
        public int? DryCows { get; set; }
        public int? PregnantCows { get; set; }

        public double Calculate()
        {
            return Math.Round(((0.017 * CowWeight + 8) * (Calves0To8 ?? 0) + 10 * (Calves9To15 ?? 0) + 
                0.017 * (DryCows ?? 0) * CowWeight + 
                (0.017 * CowWeight + 0.5) * (PregnantCows ?? 0)), 1, MidpointRounding.AwayFromZero);
        }

        public void Reset()
        {
            Calves0To8 = null;
            Calves9To15 = null;
            DryCows = null;
            PregnantCows = null;
        }
    }
}
