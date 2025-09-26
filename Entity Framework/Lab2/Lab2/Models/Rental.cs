using System;
using System.Collections.Generic;

namespace Lab2.Models;

public partial class Rental
{
    public int MovieId { get; set; }

    public int CustomerId { get; set; }

    public DateOnly RentalDate { get; set; }

    public DateOnly ReturnDate { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual Movie Movie { get; set; } = null!;
}
