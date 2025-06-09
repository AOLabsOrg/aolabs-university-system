using UniversitySystem.Domain.Common;

namespace UniversitySystem.Domain.Entities;


public class Schedule : BaseEntity
{
    private TimeOnly _startTime;
    private TimeOnly _endTime;
    private string _roomNumber = string.Empty;

    public DayOfWeek DayOfWeek { get; set; }

    public TimeOnly StartTime
    {
        get => _startTime;
        set
        {
            if (_endTime != default && value > _endTime)
                throw new ArgumentException("StartTime must be earlier than EndTime.");

            _startTime = value;
        }
    }
    public TimeOnly EndTime
    {
        get => _endTime;
        set
        {
            if (_startTime != default && value <= _startTime)
                throw new ArgumentException("EndTime must be later than StartTime.");

            _endTime = value;
        }
    }
    public string RoomNumber
    {
        get => _roomNumber;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Room number can't be empty or whitespace.");

            _roomNumber = value;
        }
    }

    public Guid CourseId { get; set; }
    public Guid InstructorId { get; set; }


    // Navigation Properties 
    public Course Course { get; set; } = default!;
    public Instructor Instructor { get; set; } = default!;
    public ICollection<Lecture> Lectures { get; set; } = new List<Lecture>();

    public Schedule(Guid courseId, Guid instructorId, DayOfWeek dayOfWeek,
        TimeOnly startTime, TimeOnly endTime, string roomNumber)
    {
        CourseId = courseId;
        InstructorId = instructorId;
        DayOfWeek = dayOfWeek;
        StartTime = startTime;
        EndTime = endTime;
        RoomNumber = roomNumber;
    }
    private Schedule() { }
}