using System;
using System.Collections.Generic;

namespace WebsiteRZA_New.Models;

public partial class Room
{
    public int RoomNumber { get; set; }

    public int Capacity { get; set; }

    public string RoomType { get; set; } = null!;

    public bool? Vacancy { get; set; }

    public bool? DisabilityAccessible { get; set; }

    public virtual ICollection<Roombooking> Roombookings { get; set; } = new List<Roombooking>();
}
