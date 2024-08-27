using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FM_DotNet.Models;

[Table("add_on", Schema = "FM")]
public partial class AddOn
{
    [Key]
    [Column("addon_id")]
    public int AddonId { get; set; }

    [Column("addon_daily_rate")]
    [Precision(38)]
    public decimal? AddonDailyRate { get; set; }

    [Column("addon_name")]
    [StringLength(255)]
    public string? AddonName { get; set; }

    [Column("rate_valid_until")]
    [MaxLength(6)]
    public DateTime? RateValidUntil { get; set; }
}
