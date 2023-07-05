using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorServerApp.Models;

public class Car
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id { get; set; } 

    public string? name { get; set; }

    public int? year { get; set; }

    public int? price { get; set; }

    public double? km { get; set; }
}
