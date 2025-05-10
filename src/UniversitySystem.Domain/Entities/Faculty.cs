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

public class Faculty : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    // Foreign Key to University
    public Guid UniversityId { get; set; }
    public University University { get; set; } = default!;

    // Navigation to Departments
    public ICollection<Department> Departments { get; set; } = new List<Department>();
}
