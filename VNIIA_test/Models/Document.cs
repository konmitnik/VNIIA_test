using System;
using System.Collections.Generic;

namespace VNIIA_test.Models;

public partial class Document
{
    public int Id;

    public int Number { get; set; }

    public DateOnly Date { get; set; }

    public string? Comment { get; set; }

    public virtual ICollection<Position> Positions { get; set; } = new List<Position>();
}
