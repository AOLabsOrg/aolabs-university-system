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

public class University : BaseEntity
{
    private string _name = string.Empty;
    private string _location = string.Empty;

    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("University name is required");
            _name = value;
        }
    }

    public string Location
    {
        get => _location;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("University location is required");
            _location = value;
        }
    }

    // Navigation Properties
    public ICollection<Faculty> Faculties { get; set; } = new List<Faculty>();
    public ICollection<Student> Students { get; set; } = new List<Student>();

    // Constructor
    public University(string name, string location)
    {
        Name = name;
        Location = location;
    }

    private University() { }
}
