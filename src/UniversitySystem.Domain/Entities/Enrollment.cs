using UniversitySystem.Domain.Common;

namespace UniversitySystem.Domain.Entities
{
    public class Enrollment : BaseEntity
    {
        private DateOnly _enrollmentDate;
        public DateOnly EnrollmentDate
        {
            get
            {
                return _enrollmentDate;
            }
            set
            {
                if (value == default)
                {
                    throw new ArgumentException("Enrollment date cannot be empty");
                }
                _enrollmentDate = value;
            }
        }
        private int _academicYear;
        public int AcademicYear
        {
            get
            {
                return _academicYear;
            }
            set
            {
                if (value < 2000 || value > DateTime.Now.Year + 4)
                {
                    throw new ArgumentException("Invalid academic year");
                }
                _academicYear = value;
            }
        }
        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
        public Enrollment(DateOnly enrollmentDate, int academicYear, Guid studentId, Guid courseId)
        {
            EnrollmentDate = enrollmentDate;
            AcademicYear = academicYear;
            StudentId = studentId;
            CourseId = courseId;
        }

        private Enrollment() { }
    }
}
