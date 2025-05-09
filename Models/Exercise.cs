namespace FitnessApp.Models
{
    public class Exercise
    {
        public int ExerciseId { get; set; }
        public string Name { get; set; }
        public string MuscleGroup { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
        public int WorkoutId { get; set; }
    }
}