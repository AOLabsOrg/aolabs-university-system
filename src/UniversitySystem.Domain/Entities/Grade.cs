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

public class Grade : BaseEntity
{
    public double GradeValue { get; set; }

    public GpaType GpaType { get; set; }

    public Guid StudentId { get; set; }

    public Guid CourseId { get; set; }

    public Course Course { get; set; } = default!;

    public Student Student { get; set; } = default!;

    public Grade(double gradeValue, GpaType gpaType, Guid studentId, Guid courseId)
    {
        GradeValue = gradeValue;
        GpaType = gpaType;
        StudentId = studentId;
        CourseId = courseId;
    }


    private Grade() { }
}
