using UniversitySystem.Domain.Common;

namespace UniversitySystem.Domain.Entities;

public class Attendance : BaseEntity
{
    private string? _notes;

    public bool IsPresent { get; set; }
    public string Notes
    {
        get => _notes ?? string.Empty;
        set
        {
            if (value != null && value.Length > 500)
                throw new ArgumentException("The note can't exceed the maximum length of 500 characters.");

            _notes = value;
        }
    }
    public Guid LectureId { get; set; }
    public Guid StudentId { get; set; }


    // Navigation Properties
    public Lecture Lecture { get; set; } = default!;
    public Student Student { get; set; } = default!;

    public Attendance(bool isPresent, string notes, Guid lectureId, Guid studentId)
    {
        IsPresent = isPresent;
        Notes = notes;
        LectureId = lectureId;
        StudentId = studentId;
    }

    private Attendance() { }
}