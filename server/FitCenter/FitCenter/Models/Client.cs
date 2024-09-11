using System;
using System.Collections.Generic;

namespace FitCenter.Models;

public partial class Client
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Abonement { get; set; } = null!;

    public DateTime? Data { get; set; }

    public long? Number { get; set; }
}
