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

public class Specialization : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    // Foreign key to Department
    public Guid DepartmentId { get; set; }
    public Department Department { get; set; } = default!;
}