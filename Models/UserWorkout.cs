namespace FitnessApp.Models
{
    public class UserWorkout
    {
        public int UserWorkoutId { get; set; }
        public int UserId { get; set; }
        public int WorkoutId { get; set; }
        public DateTime CompletedDate { get; set; }
        public string Notes { get; set; }
    }
}