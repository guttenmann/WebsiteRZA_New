using System;
using System.Collections.Generic;

namespace WebsiteRZA_New.Models;

public partial class Educationalvisit
{
    public string SchoolName { get; set; } = null!;

    public string? StageOfEducation { get; set; }

    public DateOnly DayOfVisit { get; set; }

    public int? NumOfStudents { get; set; }

    public int? NumOfStaff { get; set; }
}
