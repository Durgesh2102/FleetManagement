using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FM_DotNet.Models;

[Table("airport", Schema = "FM")]
[Index("CityId", Name = "FK2yld6il0wug59fgxke2ak2c5o")]
[Index("StateId", Name = "FKalg2cgcxjwipmkb90s9h4hfhe")]
[Index("HubId", Name = "FKsjl3o7kbfo2lblgsihfx35odv")]
[Index("AirportCode", Name = "UK509845vfob7ubc0cfvfe0ppnh", IsUnique = true)]
public partial class Airport
{
    [Key]
    [Column("airport_id")]
    public int AirportId { get; set; }

    [Column("airport_code")]
    public string? AirportCode { get; set; }

    [Column("airport_name")]
    [StringLength(255)]
    public string? AirportName { get; set; }

    [Column("city_id")]
    public int? CityId { get; set; }

    [Column("hub_id")]
    public int? HubId { get; set; }

    [Column("state_id")]
    public int? StateId { get; set; }

    [ForeignKey("CityId")]
    [InverseProperty("Airports")]
    public virtual CityMaster? City { get; set; }

    [ForeignKey("HubId")]
    [InverseProperty("Airports")]
    public virtual Hub? Hub { get; set; }

    [ForeignKey("StateId")]
    [InverseProperty("Airports")]
    public virtual StateMaster? State { get; set; }
}
