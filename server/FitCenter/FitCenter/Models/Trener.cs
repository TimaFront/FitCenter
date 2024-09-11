using System;
using System.Collections.Generic;

namespace FitCenter.Models;

public partial class Trener
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string? Rod { get; set; }

    public string? Img { get; set; }

    public string? Info { get; set; }

    public string? Price { get; set; }

    public string[]? Spis { get; set; }

    public string? Minage { get; set; }
}
