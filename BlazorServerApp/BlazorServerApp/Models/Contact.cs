using System;
using System.Collections.Generic;

namespace BlazorServerApp.Models;

public partial class Contact
{
    public string firstName { get; set; } = null!;

    public string? lastName { get; set; }

    public string? email { get; set; }
}
