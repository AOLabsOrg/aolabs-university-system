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
    public string Name { get; set; } = string.Empty;
    public string? Location { get; set; }

    public ICollection<Faculty> Faculties { get; set; } = new List<Faculty>();
}
