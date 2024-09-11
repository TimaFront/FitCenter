using System;
using System.Collections.Generic;

namespace FitCenter.Models;

public partial class Abonement
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Client> Clients { get; } = new List<Client>();
}
