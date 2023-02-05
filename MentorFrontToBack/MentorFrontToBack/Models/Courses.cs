using Microsoft.AspNetCore.Mvc;

namespace MentorFrontToBack.Models
{
    public class Courses
    {
        public int Id { get; set; }
        public string? Image { get; set; }
        public string? CourseName { get; set; }
        public int CoursePrice { get; set; }

        public string? CourseDescription { get; set; }
        public string? CourseTitle { get; set; }
        public int TeacherId { get; set; }
        public Teachers? Teacher { get; set; }

    }
}
