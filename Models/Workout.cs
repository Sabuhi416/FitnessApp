namespace FitnessApp.Models
{
    public class Workout
    {
        public int WorkoutId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DurationMinutes { get; set; }
        public string Difficulty { get; set; }
        public int FitnessPlanId { get; set; }
    }
}