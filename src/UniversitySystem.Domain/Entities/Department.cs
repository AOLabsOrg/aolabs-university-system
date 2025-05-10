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
    public string Name { get; set; } = string.Empty;

    // Foreign key to Faculty
    public Guid FacultyId { get; set; }
    public Faculty Faculty { get; set; } = default!;

    // Navigation to Specializations
    public ICollection<Specialization> Specializations { get; set; } = new List<Specialization>();
}