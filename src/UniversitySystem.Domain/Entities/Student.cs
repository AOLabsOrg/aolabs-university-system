using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySystem.Domain.Common;
using UniversitySystem.Domain.Enums;

namespace UniversitySystem.Domain.Entities
{
    public class Student : BaseEntity
    {
        public string FullName { get; set; }
        public string NationalId { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public GpaType Gpa {  get; set; }
        public DateTime BirthDate { get; set; }
        public int AcademicYear { get; set; }

        // Foreign key to Department
        public Guid DepartmentId { get; set; }
        public Department Department { get; set; } = default!;

        // Foreign key to University
        public Guid UniversityId { get; set; }
        public University University { get; set; } = default!;
        
        // Foreign key to Faculty
        public Guid FacultyId { get; set; }
        public Faculty Faculty{ get; set; } = default!;

        // Foreign key to Specialization
        public Guid SpecializationId { get; set; }
        public Specialization Specialization { get; set; } = default!;

    }

    
}
