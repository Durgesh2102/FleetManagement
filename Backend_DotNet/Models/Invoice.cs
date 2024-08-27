using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FM_DotNet.Models;

[Table("invoice", Schema = "FM")]
public partial class Invoice
{
    [Key]
    [Column("invoice_id")]
    public int InvoiceId { get; set; }

    [Column("bookid")]
    public int Bookid { get; set; }

    [Column("c_aadhar_no")]
    [StringLength(255)]
    public string? CAadharNo { get; set; }

    [Column("c_email_id")]
    [StringLength(255)]
    public string? CEmailId { get; set; }

    [Column("c_mobile_no")]
    [StringLength(255)]
    public string? CMobileNo { get; set; }

    [Column("c_name")]
    [StringLength(255)]
    public string? CName { get; set; }

    [Column("c_pass_no")]
    [StringLength(255)]
    public string? CPassNo { get; set; }

    [Column("carid")]
    public int Carid { get; set; }

    [Column("customerid")]
    public int Customerid { get; set; }

    [Column("emp_name")]
    [StringLength(255)]
    public string? EmpName { get; set; }

    [Column("end_date")]
    [MaxLength(6)]
    public DateTime? EndDate { get; set; }

    [Column("handover_date")]
    [MaxLength(6)]
    public DateTime? HandoverDate { get; set; }

    [Column("is_returned", TypeName = "enum('N','Y')")]
    public string? IsReturned { get; set; }

    [Column("p_hub_id")]
    public int? PHubId { get; set; }

    [Column("r_hub_id")]
    public int? RHubId { get; set; }

    [Column("rate")]
    public double Rate { get; set; }

    [Column("rental_amount")]
    public double RentalAmount { get; set; }

    [Column("start_date")]
    [MaxLength(6)]
    public DateTime? StartDate { get; set; }

    [Column("total_addon_amount")]
    public double TotalAddonAmount { get; set; }

    [Column("total_amount")]
    public double TotalAmount { get; set; }
}
