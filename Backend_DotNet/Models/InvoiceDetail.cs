using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FM_DotNet.Models;

[Table("invoice_detail", Schema = "FM")]
public partial class InvoiceDetail
{
    [Key]
    [Column("idetail_id")]
    public int IdetailId { get; set; }

    [Column("addon_id")]
    public int AddonId { get; set; }

    [Column("amt")]
    public int Amt { get; set; }

    [Column("invoice_id")]
    public int InvoiceId { get; set; }
}
