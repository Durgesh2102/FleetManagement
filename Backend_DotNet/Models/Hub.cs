using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FM_DotNet.Models;

[Table("hub", Schema = "FM")]
[Index("StateId", Name = "FKhkq33ikm1jpvqwpg0fm42ojv0")]
[Index("CityId", Name = "FKje7oa2pw4xmhwh24felm6b8et")]
[Index("ContactNumber", Name = "UKr8krl9im6itf4cbrnwver2pd8", IsUnique = true)]
public partial class Hub
{
    [Key]
    [Column("hub_id")]
    public int HubId { get; set; }

    [Column("contact_number")]
    public long? ContactNumber { get; set; }

    [Column("hub_address_and_details", TypeName = "text")]
    public string? HubAddressAndDetails { get; set; }

    [Column("hub_name")]
    [StringLength(255)]
    public string? HubName { get; set; }

    [Column("city_id")]
    public int? CityId { get; set; }

    [Column("state_id")]
    public int? StateId { get; set; }

    [InverseProperty("Hub")]
    public virtual ICollection<Airport> Airports { get; } = new List<Airport>();

    [InverseProperty("Hub")]
    public virtual ICollection<Car> Cars { get; } = new List<Car>();

    [ForeignKey("CityId")]
    [InverseProperty("Hubs")]
    public virtual CityMaster? City { get; set; }

    [ForeignKey("StateId")]
    [InverseProperty("Hubs")]
    public virtual StateMaster? State { get; set; }
}
