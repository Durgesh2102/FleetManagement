using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FM_DotNet.Models;

[Table("booking", Schema = "FM")]
[Index("CartypeId", Name = "FK1iw8k5qheeqk041n43wishifu")]
[Index("CustId", Name = "FK57t2cgb8xr3mn2vms6j6t55ws")]
public partial class Booking
{
    [Key]
    [Column("booking_id")]
    public long BookingId { get; set; }

    [Column("address")]
    [StringLength(255)]
    public string? Address { get; set; }

    [Column("booking_date", TypeName = "date")]
    public DateTime? BookingDate { get; set; }

    [Column("daily_rate")]
    [Precision(38)]
    public decimal? DailyRate { get; set; }

    [Column("email_id")]
    [StringLength(255)]
    public string? EmailId { get; set; }

    [Column("end_date", TypeName = "date")]
    public DateTime? EndDate { get; set; }

    [Column("first_name")]
    [StringLength(255)]
    public string? FirstName { get; set; }

    [Column("last_name")]
    [StringLength(255)]
    public string? LastName { get; set; }

    [Column("monthly_rate")]
    [Precision(38)]
    public decimal? MonthlyRate { get; set; }

    [Column("p_hub_id")]
    public int? PHubId { get; set; }

    [Column("pin")]
    [StringLength(255)]
    public string? Pin { get; set; }

    [Column("r_hub_id")]
    public int? RHubId { get; set; }

    [Column("start_date", TypeName = "date")]
    public DateTime? StartDate { get; set; }

    [Column("state")]
    [StringLength(255)]
    public string? State { get; set; }

    [Column("weekly_rate")]
    [Precision(38)]
    public decimal? WeeklyRate { get; set; }

    [Column("cartype_id")]
    public long? CartypeId { get; set; }

    [Column("cust_id")]
    public int? CustId { get; set; }

    [InverseProperty("Booking")]
    public virtual ICollection<BookingDetail> BookingDetails { get; } = new List<BookingDetail>();

    [ForeignKey("CartypeId")]
    [InverseProperty("Bookings")]
    public virtual CarType? Cartype { get; set; }

    [ForeignKey("CustId")]
    [InverseProperty("Bookings")]
    public virtual Customer? Cust { get; set; }
}
