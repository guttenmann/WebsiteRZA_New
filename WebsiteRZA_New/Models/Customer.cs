using System;
using System.Collections.Generic;

namespace WebsiteRZA_New.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Postcode { get; set; }

    public string? PhoneNumber { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public int? LoyaltyPoints { get; set; }

    public virtual ICollection<Roombooking> Roombookings { get; set; } = new List<Roombooking>();

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
