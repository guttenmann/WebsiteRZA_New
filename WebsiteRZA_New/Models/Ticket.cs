using System;
using System.Collections.Generic;

namespace WebsiteRZA_New.Models;

public partial class Ticket
{
    public int TicketId { get; set; }

    public bool? Validate { get; set; }

    public int? AttractionId { get; set; }

    public virtual Attraction? Attraction { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
