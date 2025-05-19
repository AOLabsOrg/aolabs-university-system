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

namespace UniversitySystem.Domain.Entities;

public class Department : BaseEntity
{
    private string _name = string.Empty;

    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Department name is required");
            _name = value;
        }
    }

    public Guid FacultyId { get; set; }

    public Faculty Faculty { get; set; } = default!;
    public ICollection<Specialization> Specializations { get; set; } = new List<Specialization>();
    public ICollection<Student> Students { get; set; } = new List<Student>();

    public Department(string name, Guid facultyId)
    {
        Name = name;
        FacultyId = facultyId;
    }

    private Department() { }
}