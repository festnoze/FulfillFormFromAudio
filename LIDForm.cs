using System;
using System.ComponentModel.DataAnnotations;

namespace FulfillFormFromWithAudio;

public class LIDForm
{
    [Required]
    public Identity Identity { get; set; } = new();
    [Required]
    public Address Address { get; set; } = new();
    [Required]
    public ContactInfo ContactInfo { get; set; } = new();
    [Required]
    public TechnicalInfo TechnicalInfo { get; set; } = new();
    [Required]
    public Utm Utm { get; set; } = new();
    [Required]
    public Additional Additional { get; set; } = new();
}

public class Identity
{
    [Required, MinLength(1), MaxLength(100)]
    public string Nom { get; set; } = string.Empty;
    [Required, MinLength(1), MaxLength(100)]
    public string Prenom { get; set; } = string.Empty;
    [MinLength(2), MaxLength(5)]
    public string? Gender { get; set; }
    public DateTime? Birthdate { get; set; }
    [Range(1900, 2100)]
    public int? Birthyear { get; set; }
    [MinLength(1), MaxLength(100)]
    public string? ProfessionalSituation { get; set; }
    [MinLength(1), MaxLength(100)]
    public string? DiplomaLevel { get; set; }
    [MinLength(1), MaxLength(100)]
    public string? DiplomaName { get; set; }
}

public class Address
{
    [Required, MinLength(1), MaxLength(200)]
    public string Street { get; set; } = string.Empty;
    [Required, MinLength(4), MaxLength(10)]
    public string PostalCode { get; set; } = string.Empty;
    [Required, MinLength(1), MaxLength(100)]
    public string City { get; set; } = string.Empty;
    [Required, MinLength(2), MaxLength(20)]
    public string Pays { get; set; } = "FR";
}

public class ContactInfo
{
    [Required, MinLength(5), MaxLength(100)]
    public string Email { get; set; } = string.Empty;
    [Required, MinLength(8), MaxLength(20)]
    public string Telephone { get; set; } = string.Empty;
}

public class TechnicalInfo
{
    [Required, MinLength(5), MaxLength(200)]
    public string Url { get; set; } = string.Empty;
    [MinLength(7), MaxLength(15)]
    public string? IpAddress { get; set; }
    [MinLength(1), MaxLength(50)]
    public string? Device { get; set; }
    public DateTime? FirstVisit { get; set; }
    [MinLength(1), MaxLength(200)]
    public string? FirstPage { get; set; }
}

public class Utm
{
    [Required, MinLength(1), MaxLength(100)]
    public string UtmSource { get; set; } = string.Empty;
    [Required, MinLength(3), MaxLength(50)]
    public string UtmMedium { get; set; } = string.Empty;
    [MinLength(1), MaxLength(100)]
    public string? UtmCampaign { get; set; }
    [MinLength(1), MaxLength(100)]
    public string? UtmContent { get; set; }
    [MinLength(1), MaxLength(100)]
    public string? UtmTerm { get; set; }
}

public class Additional
{
    [MaxLength(100)]
    public string? Thematique { get; set; }
    [Required, MinLength(1), MaxLength(100)]
    public string Formulaire { get; set; } = string.Empty;
    [MinLength(1), MaxLength(500)]
    public string? Consentement { get; set; }
    [MinLength(5), MaxLength(200)]
    public string? DocumentUrl { get; set; }
    [MinLength(1), MaxLength(50)]
    public string? Funding { get; set; }
    [MinLength(1), MaxLength(50)]
    public string? CaptureChannel { get; set; }
    [MinLength(1), MaxLength(50)]
    public string? FormType { get; set; }
    [MinLength(1), MaxLength(50)]
    public string? FormArea { get; set; }
    [MaxLength(500)]
    public string? FormMoreInformation { get; set; }
    [MaxLength(500)]
    public string? Comments { get; set; }
    [MinLength(1), MaxLength(100)]
    public string? TrainingCourseId { get; set; }
    [Required, MinLength(1), MaxLength(50)]
    public string Alternance { get; set; } = "Non";
    [MinLength(1), MaxLength(100)]
    public string? TechSource { get; set; }
    public string? Cv { get; set; }
}

