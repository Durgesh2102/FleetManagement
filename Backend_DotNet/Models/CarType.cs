using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FM_DotNet.Models;

[Table("car_type", Schema = "FM")]
public partial class CarType
{
    [Key]
    [Column("car_type_id")]
    public long CarTypeId { get; set; }

    [Column("car_type_name")]
    [StringLength(255)]
    public string? CarTypeName { get; set; }

    [Column("daily_rate")]
    public double? DailyRate { get; set; }

    [Column("image_path")]
    [StringLength(255)]
    public string? ImagePath { get; set; }

    [Column("monthly_rate")]
    public double? MonthlyRate { get; set; }

    [Column("weekly_rate")]
    public double? WeeklyRate { get; set; }

    [InverseProperty("Cartype")]
    public virtual ICollection<Booking> Bookings { get; } = new List<Booking>();

    [InverseProperty("CarType")]
    public virtual ICollection<Car> Cars { get; } = new List<Car>();
}
