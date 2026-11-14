namespace FeedCalculator
{
    public class FeedCalculatorModel
    {
        public const double CowWeight = 400.0;

        public int? Calves0To8 { get; set; }
        public int? Calves9To15 { get; set; }
        public int? DryCows { get; set; }
        public int? PregnantCows { get; set; }
        public int? MaleCows { get; set; }
        public int? Days { get; set; } 
        public double Overall {  get; set; }

        public double Calculate()
        {
            double dailyTotal =
                 (0.017 * CowWeight + 8) * (Calves0To8 ?? 0) +
                 10 * (Calves9To15 ?? 0) +
                 0.017 * CowWeight * ((DryCows ?? 0) + (MaleCows ?? 0)) +
                 (0.017 * CowWeight + 0.5) * (PregnantCows ?? 0);

            Overall = Math.Round(dailyTotal * (Days ?? 1), 1, MidpointRounding.AwayFromZero);
            return Overall;
        }

        public void Reset()
        {
            Calves0To8 = null;
            Calves9To15 = null;
            DryCows = null;
            PregnantCows = null;
            MaleCows = null;
            Days = null;
        }

       
    }
}
