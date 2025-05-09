namespace FitnessApp.Models
{
    public class FitnessPlan
    {
        public int FitnessPlanId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DurationWeeks { get; set; }
        public string Goal { get; set; }
    }
}