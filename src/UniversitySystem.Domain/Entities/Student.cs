/*
 * Copyright (c) 2025 AOLabs
 * This file is part of the AOLabs University System project.
 *
 * Licensed under the MIT License.
 * You may obtain a copy of the License at:
 * https://opensource.org/licenses/MIT
 *
 * You are free to use, modify, and distribute this file
 * under the terms of the license.
 */

using UniversitySystem.Domain.Common;
using UniversitySystem.Domain.Enums;

namespace UniversitySystem.Domain.Entities;

public class Student : BaseEntity
{
    public string FullName { get; set; } = null!;
    public string NationalId { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Gender { get; set; } = null!;
    public GpaType Gpa { get; set; }
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
    public Faculty Faculty { get; set; } = default!;

    // Foreign key to Specialization
    public Guid SpecializationId { get; set; }
    public Specialization Specialization { get; set; } = default!;

}


