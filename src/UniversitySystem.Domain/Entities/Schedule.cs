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

public class Schedule : BaseEntity
{
    private string _roomNumber = string.Empty;

    public DayOfWeek DayOfWeek { get; set; }

    public TimeOnly StartTime { get; set; }

    public TimeOnly EndTime { get; set; }

    public string RoomNumber
    {
        get => _roomNumber;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Room number is required", nameof(value));

            _roomNumber = value;
        }
    }

    public Guid CourseId { get; set; }

    public Guid InstructorId { get; set; }

    public Course Course { get; set; } = default!;

    public Instructor Instructor { get; set; } = default!;

    public ICollection<Lecture> Lectures { get; set; } = new List<Lecture>();

    public Schedule(DayOfWeek dayOfWeek, TimeOnly startTime, TimeOnly endTime, string roomNumber, Guid courseId, Guid instructorId)
    {
        DayOfWeek = dayOfWeek;
        StartTime = startTime;
        EndTime = endTime;
        RoomNumber = roomNumber ?? throw new ArgumentNullException(nameof(roomNumber), "Room number is required");
        CourseId = courseId;
        InstructorId = instructorId;
    }

    // Parameterless constructor for EF Core
    private Schedule() { }
}
