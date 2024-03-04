using System;
using System.Collections.Generic;

namespace VNIIA_test.Models;

public partial class Position
{
    public int Id;

    public int Number { get; set; }

    public string Name { get; set; } = null!;

    public double Sum { get; set; }

    public int? DocId { get; set; }

    public virtual Document? Doc { get; set; }
}
