using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FM_DotNet.Models;

[Table("customer", Schema = "FM")]
[Index("Email", Name = "UKdwk6cx0afu8bs9o4t536v1j5v", IsUnique = true)]
public partial class Customer
{
    [Key]
    [Column("customer_id")]
    public int CustomerId { get; set; }

    [Column("address_line1")]
    [StringLength(255)]
    public string? AddressLine1 { get; set; }

    [Column("address_line2")]
    [StringLength(255)]
    public string? AddressLine2 { get; set; }

    [Column("city")]
    [StringLength(255)]
    public string? City { get; set; }

    [Column("credit_card_number")]
    [StringLength(255)]
    public string? CreditCardNumber { get; set; }

    [Column("credit_card_type")]
    [StringLength(255)]
    public string? CreditCardType { get; set; }

    [Column("date_of_birth", TypeName = "date")]
    public DateTime? DateOfBirth { get; set; }

    [Column("driving_license_number")]
    [StringLength(255)]
    public string? DrivingLicenseNumber { get; set; }

    [Column("email")]
    public string? Email { get; set; }

    [Column("first_name")]
    [StringLength(255)]
    public string? FirstName { get; set; }

    [Column("idp_number")]
    [StringLength(255)]
    public string? IdpNumber { get; set; }

    [Column("issued_bydl")]
    [StringLength(255)]
    public string? IssuedBydl { get; set; }

    [Column("last_name")]
    [StringLength(255)]
    public string? LastName { get; set; }

    [Column("mobile_number")]
    [StringLength(255)]
    public string? MobileNumber { get; set; }

    [Column("passport_issue_date", TypeName = "date")]
    public DateTime? PassportIssueDate { get; set; }

    [Column("passport_issued_by")]
    [StringLength(255)]
    public string? PassportIssuedBy { get; set; }

    [Column("passport_number")]
    [StringLength(255)]
    public string? PassportNumber { get; set; }

    [Column("passport_valid_from", TypeName = "date")]
    public DateTime? PassportValidFrom { get; set; }

    [Column("passport_valid_through", TypeName = "date")]
    public DateTime? PassportValidThrough { get; set; }

    [Column("password")]
    [StringLength(255)]
    public string? Password { get; set; }

    [Column("phone_number")]
    [StringLength(255)]
    public string? PhoneNumber { get; set; }

    [Column("pincode")]
    [StringLength(255)]
    public string? Pincode { get; set; }

    [Column("valid_throughdl", TypeName = "date")]
    public DateTime? ValidThroughdl { get; set; }

    [InverseProperty("Cust")]
    public virtual ICollection<Booking> Bookings { get; } = new List<Booking>();
}
