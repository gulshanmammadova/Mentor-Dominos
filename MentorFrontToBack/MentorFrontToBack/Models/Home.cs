namespace MentorFrontToBack.Models
{
    public class Home
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public Courses? Course { get; set; } 
    }
}
