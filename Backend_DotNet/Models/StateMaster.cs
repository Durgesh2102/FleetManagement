using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FM_DotNet.Models;

[Table("state_master", Schema = "FM")]
[Index("StateName", Name = "UKm5af6dlen3aq3mvubt194s0j6", IsUnique = true)]
public partial class StateMaster
{
    [Key]
    [Column("state_id")]
    public int StateId { get; set; }

    [Column("state_name")]
    public string? StateName { get; set; }

    [InverseProperty("State")]
    public virtual ICollection<Airport> Airports { get; } = new List<Airport>();

    [InverseProperty("State")]
    public virtual ICollection<CityMaster> CityMasters { get; } = new List<CityMaster>();

    [InverseProperty("State")]
    public virtual ICollection<Hub> Hubs { get; } = new List<Hub>();
}
