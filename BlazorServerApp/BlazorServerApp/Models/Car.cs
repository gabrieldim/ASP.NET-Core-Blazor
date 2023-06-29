using System;
using System.Collections.Generic;

namespace BlazorServerApp.Models;

public partial class Car
{
    public int id { get; set; }

    public string? name { get; set; }

    public int? year { get; set; }

    public int? price { get; set; }

    public double? km { get; set; }
}
