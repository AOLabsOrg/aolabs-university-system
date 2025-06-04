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

public class Lecture : BaseEntity
{
    private string _topic = string.Empty;

    public DateOnly Date { get; set; }

    public string Topic
    {
        get => _topic;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Lecture topic is required", nameof(value));

            _topic = value;
        }
    }

    public Guid CourseId { get; set; }

    public Guid InstructorId { get; set; }

    public Guid ScheduleId { get; set; }

    public Course Course { get; set; } = default!;

    public Instructor Instructor { get; set; } = default!;

    public Schedule Schedule { get; set; } = default!;

    public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    public Lecture(string topic)
    {
        Topic = topic;
    }

    // Parameterless constructor for EF Core
    private Lecture() { }
}
