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

public class Instructor : BaseEntity
{
    private string _fullName = string.Empty;
    private string _email = string.Empty;

    public string FullName
    {
        get => _fullName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Instructor full name is required");
            _fullName = value;
        }
    }

    public string Email
    {
        get => _email;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Instructor email is required");
            if (!value.Contains("@"))
                throw new ArgumentException("Instructor email must contain '@'");
            _email = value;
        }
    }

    public InstructorType InstructorType { get; set; }

    public Guid UniversityId { get; set; }
    public Guid FacultyId { get; set; }
    public Guid DepartmentId { get; set; }
    public Guid SpecializationId { get; set; }

    public University University { get; set; } = default!;
    public Faculty Faculty { get; set; } = default!;
    public Department Department { get; set; } = default!;
    public Specialization Specialization { get; set; } = default!;

    public ICollection<CourseInstructor> CourseInstructors { get; set; } = new List<object>();
    public ICollection<Lecture> Lectures { get; set; } = new List<Lecture>();
    public ICollection<Schedule> Schedules { get; set; } = new List<object>();

    public Instructor(string fullName, string email, InstructorType instructorType, Guid universityId, Guid facultyId, Guid departmentId, Guid specializationId)
    {
        FullName = fullName;
        Email = email;
        InstructorType = instructorType;
        UniversityId = universityId;
        FacultyId = facultyId;
        DepartmentId = departmentId;
        SpecializationId = specializationId;
    }

    private Instructor() { }
}
