using UniversitySystem.Domain.Common;

namespace UniversitySystem.Domain.Entities;

public class Course : BaseEntity
{
    private string _name = string.Empty;
    private string _code = string.Empty;
    private int _creditHours;

    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Course name cannot be empty or whitespace");

            _name = value;
        }
    }
    public string Code
    {
        get => _code;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Course Code cannot be empty or whitespace");

            _code = value;
        }
    }
    public int CreditHours
    {
        get => _creditHours;
        set
        {
            if (value <= 0 || value == null)
                throw new ArgumentException("Credit hours must be greater than zero");

            _creditHours = value;
        }
    }

    public Guid SpecializationId { get; set; }


    // Navigation Properties
    public Specialization Specialization { get; set; } = default!;
    public ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
    public ICollection<Lecture> Lectures { get; set; } = new List<Lecture>();
    public ICollection<Enrollment> Enrollements { get; set; } = new List<Enrollment>();
    public ICollection<Grade> Grades { get; set; } = new List<Grade>();
    public ICollection<CourseInstructor> CourseInstructors { get; set; } = new List<CourseInstructor>();
    public ICollection<Evaluation> Evaluations { get; set; } = new List<Evaluation>();

    public Course(string name, string code, int creditHours, Guid specializationId)
    {
        Name = name;
        Code = code;
        CreditHours = creditHours;
        SpecializationId = specializationId;
    }
    private Course() { }
}