using UniversitySystem.Domain.Common;

namespace UniversitySystem.Domain.Entities;

public class CourseInstructor
{
    public Guid CourseId { get; set; }
    public Guid InstructorId { get; set; }

    // Navigation Properties
    public Course Course { get; set; } = default!;
    public Instructor Instructor { get; set; } = default!;

    public CourseInstructor(Guid courseId, Guid instructorId)
    {
        CourseId = courseId;
        InstructorId = instructorId;
    }
    private CourseInstructor() { }

}