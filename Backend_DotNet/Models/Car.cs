using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FM_DotNet.Models;

[Table("car", Schema = "FM")]
[Index("CarTypeId", Name = "FKggtv0dpqfowlhobef4e9qrdlm")]
[Index("HubId", Name = "FKlannauot1phgh8tglmui81t8f")]
[Index("NumberPlate", Name = "UK1wy3rm2ysgt7gevwji4v205ri", IsUnique = true)]
public partial class Car
{
    [Key]
    [Column("car_id")]
    public long CarId { get; set; }

    [Column("status")]
    [StringLength(50)]
    public string? Status { get; set; }

    [Column("capacity")]
    public int? Capacity { get; set; }

    [Column("car_name")]
    [StringLength(255)]
    public string? CarName { get; set; }

    [Column("is_available", TypeName = "enum('N','Y')")]
    public string? IsAvailable { get; set; }

    [Column("maintenance_due_date")]
    [MaxLength(6)]
    public DateTime? MaintenanceDueDate { get; set; }

    [Column("mileage")]
    public double? Mileage { get; set; }

    [Column("number_plate")]
    [StringLength(50)]
    public string? NumberPlate { get; set; }

    [Column("car_type_id")]
    public long? CarTypeId { get; set; }

    [Column("hub_id")]
    public int? HubId { get; set; }

    [ForeignKey("CarTypeId")]
    [InverseProperty("Cars")]
    public virtual CarType? CarType { get; set; }

    [ForeignKey("HubId")]
    [InverseProperty("Cars")]
    public virtual Hub? Hub { get; set; }
}
