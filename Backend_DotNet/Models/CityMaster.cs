using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FM_DotNet.Models;

[Table("city_master", Schema = "FM")]
[Index("StateId", Name = "FKfxtjuwt9iqx9n7xl6f8wl6uu4")]
public partial class CityMaster
{
    [Key]
    [Column("city_id")]
    public int CityId { get; set; }

    [Column("city_name")]
    [StringLength(255)]
    public string? CityName { get; set; }

    [Column("state_id")]
    public int? StateId { get; set; }

    [InverseProperty("City")]
    public virtual ICollection<Airport> Airports { get; } = new List<Airport>();

    [InverseProperty("City")]
    public virtual ICollection<Hub> Hubs { get; } = new List<Hub>();

    [ForeignKey("StateId")]
    [InverseProperty("CityMasters")]
    public virtual StateMaster? State { get; set; }
}
