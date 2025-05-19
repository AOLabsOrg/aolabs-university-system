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
    private string _fullName = string.Empty;
    private string _nationalId = string.Empty;
    private string _email = string.Empty;

    public string FullName
    {
        get => _fullName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Student name is required");
            _fullName = value;
        }
    }

    public string NationalId
    {
        get => _nationalId;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("National ID is required");
            if (value.Length != 14)
                throw new ArgumentException("National ID must be 14 digits");
            _nationalId = value;
        }
    }

    public string Email
    {
        get => _email;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Email is required");
            if (!value.Contains('@'))
                throw new ArgumentException("Email is invalid");
            _email = value;
        }
    }

    public Gender Gender { get; set; }

    public DateTime BirthDate { get; set; }

    public int AcademicYear { get; set; }

    public int Level { get; set; }

    public GpaType GpaType { get; set; }

    public Guid UniversityId { get; set; }
    public Guid FacultyId { get; set; }
    public Guid DepartmentId { get; set; }
    public Guid SpecializationId { get; set; }

    public University University { get; set; } = default!;
    public Faculty Faculty { get; set; } = default!;
    public Department Department { get; set; } = default!;
    public Specialization Specialization { get; set; } = default!;

    public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    public ICollection<Grade> Grades { get; set; } = new List<Grade>();
    public ICollection<Evaluation> Evaluations { get; set; } = new List<Evaluation>();
    public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    public Student(string fullName, string nationalId, string email, Gender gender, DateTime birthDate,
        int academicYear, int level, GpaType gpaType, Guid universityId, Guid facultyId,
        Guid departmentId, Guid specializationId)
    {
        FullName = fullName;
        NationalId = nationalId;
        Email = email;
        Gender = gender;
        BirthDate = birthDate;
        AcademicYear = academicYear;
        Level = level;
        GpaType = gpaType;
        UniversityId = universityId;
        FacultyId = facultyId;
        DepartmentId = departmentId;
        SpecializationId = specializationId;
    }

    private Student() { }
}


